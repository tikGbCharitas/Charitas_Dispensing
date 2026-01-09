using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using AvicennaDispensing.Models;
using AvicennaDispensing.ViewModels;
using AvicennaDispensing.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Serilog;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;
using static AvicennaDispensing.ViewModels.BinTransferViewModel;

namespace AvicennaDispensing.Controllers
{
    public class BinTransferController : BaseController
    {
        private readonly IStringLocalizer _sharedlocalizer;
        private readonly IStringLocalizer _localizer;
        public BinTransferController(ApplicationDbContext context, IStringLocalizerFactory localizerFactory) : base(context)
        {
            _sharedlocalizer = localizerFactory.Create("Views.Shared.Common", Assembly.GetExecutingAssembly().GetName().Name!);
            _localizer = localizerFactory.Create("Views.BinTransfer.Index", Assembly.GetExecutingAssembly().GetName().Name!); ;
        }

        #region Main View

        public async Task<IActionResult> Index(string? LocID)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)} with Argument {LocID}");

            var viewmodel = new LocationViewModel();

            string? LocationArray = User.FindFirst(ClaimTypesCustom.Service_Unit)?.Value;
            if (!string.IsNullOrWhiteSpace(LocationArray))
            {
                var LocationIDList = LocationArray.Split('|');
                var LocationList = _context.Locations.AsEnumerable()
                                                    .Where(a => LocationIDList.Contains(a.LocationID))
                                                    .Select(x => new LocationViewModel.LocationsDetail
                                                    {
                                                        LocationID = x.LocationID,
                                                        LocationName = x.LocationName
                                                    }).ToList();
                viewmodel.LocationList = LocationList;
            }

            if (!string.IsNullOrWhiteSpace(LocID))
            {
                viewmodel.SelectedLocationID = LocID;
                var location = await _context.Locations.FirstOrDefaultAsync(a => a.LocationID == LocID);
                if (location != null)
                {
                    viewmodel.SelectedLocationName = location.LocationName;
                }
            }

            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)} with return data {JsonSerializer.Serialize(viewmodel)}");
            return View(viewmodel);
        }

        #endregion

        #region Data Retrieval

        public async Task<IActionResult> GetBinsWithItemCount(string locationID, string? searchQuery = null)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetBinsWithItemCount)} with argument Loc: {locationID} and search: {searchQuery}");
            ViewBag.Search = searchQuery;

            try
            {
                var bins = await GetBinsWithItemCountData(locationID, searchQuery);
                
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return PartialView("_BinList", bins);
                }
                
                return Json(new { success = true, bins });
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"{_UserID} Accessing {_ControllerName} on method {nameof(GetBinsWithItemCount)}");
                return Json(new { success = false, message = "Error retrieving bins" });
            }
        }

        private async Task<List<BinDetail>> GetBinsWithItemCountData(string locationID, string? searchQuery)
        {
            searchQuery = searchQuery?.Trim();

            var query = (
                            from bin in _context.MultiBatchItemBins.AsNoTracking()
                            join balanceBin in _context.MultiBatchBalanceBins.AsNoTracking()
                                on bin.BinID equals balanceBin.BinID
                            where bin.LocationID == locationID
                                    && balanceBin.Quantity > 0
                            group balanceBin by new { bin.BinID, bin.BinName } into g
                            select new BinDetail
                            {
                                BinID = g.Key.BinID,
                                BinName = g.Key.BinName,
                                ItemCount = g.Select(x => x.ItemID).Distinct().Count(),
                            }
                        );
            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(x =>
                    EF.Functions.Like(x.BinName, $"%{searchQuery}%"));
            }

            return await query
                .OrderBy(x => x.BinName)
                .Take(100)
                .ToListAsync();
        }

        public async Task<IActionResult> GetBinItems(string locationID, int binID, string? searchQuery = null)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetBinItems)} with LocationID={locationID}, BinID={binID}, searchQuery={searchQuery}");
            ViewBag.Search = searchQuery;

            try
            {
                // Get all items with variants
                var items = (
                    from balanceBin in _context.MultiBatchBalanceBins.AsNoTracking()
                    join item in _context.Items.AsNoTracking() on balanceBin.ItemID equals item.ItemID
                    join bin in _context.MultiBatchItemBins.AsNoTracking() on balanceBin.BinID equals bin.BinID
                    where balanceBin.LocationID == locationID
                          && balanceBin.BinID == binID
                          && balanceBin.Quantity > 0
                    select new
                    {
                        balanceBin.ItemID,
                        item.ItemName,
                        balanceBin.NIE_BPOM,
                        balanceBin.BatchID,
                        balanceBin.ExpiredDate,
                        balanceBin.Quantity,
                    }
                );

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    items = items.Where(x =>
                                EF.Functions.Like(x.ItemID, $"%{searchQuery}%") ||
                                EF.Functions.Like(x.ItemName, $"%{searchQuery}%"));
                }

                // Group by ItemID for better UX
                var groupedItems = await items
                    .GroupBy(x => new { x.ItemID, x.ItemName })
                    .Select(g => new BinItemDetailGrouped
                    {
                        ItemID = g.Key.ItemID,
                        ItemName = g.Key.ItemName,
                        TotalQuantity = g.Sum(x => x.Quantity),
                        VariantCount = g.Count()
                    })
                    .OrderBy(x => x.ItemName)
                    .Take(100)
                    .ToListAsync();

                Log.Information($"{_UserID} Retrieved {groupedItems.Count} items (grouped) from Bin {binID}");

                // Return partial view for better performance on low-end devices
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return PartialView("_ItemList", groupedItems);
                }

                return Json(new { success = true, items = groupedItems });
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"{_UserID} Error in {nameof(GetBinItems)}");
                return Json(new { success = false, message = "Error retrieving bin items" });
            }
        }

        public async Task<IActionResult> GetAvailableBins(string locationID, int excludeBinID)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetAvailableBins)} with LocationID={locationID}, ExcludeBinID={excludeBinID}");

            try
            {
                var bins = await _context.MultiBatchItemBins
                    .AsNoTracking()
                    .Where(b => b.LocationID == locationID && b.BinID != excludeBinID)
                    .OrderBy(b => b.BinName)
                    .Select(b => new
                    {
                        binID = b.BinID,
                        binName = b.BinName
                    })
                    .ToListAsync();

                return Json(new { success = true, bins, firstSelection = _localizer["SelectDestinationBin"]?.Value });
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"{_UserID} Error in {nameof(GetAvailableBins)}");
                return Json(new { success = false, message = "Error retrieving available bins" });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTransferGroup([FromBody]JsonElement request)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(AddTransferGroup)} with payload={request}");

            try
            {
                return PartialView("_TransferItem", request);
            }

            catch (Exception ex)
            {
                Log.Error(ex, $"{_UserID} Error in {nameof(AddTransferGroup)}");
                return Json(new { success = false, message = "Error retrieving item variants" });
            }
        }

        #endregion

        #region Transfer Operations

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProcessTransfer([FromBody] JsonElement request)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(ProcessTransfer)} with payload={request}");

            // Validate request structure
            if (request.ValueKind == JsonValueKind.Undefined || request.ValueKind == JsonValueKind.Null)
            {
                Log.Warning($"{_UserID} Invalid request - null or undefined");
                return Json(new { success = false, message = "Invalid request data" });
            }

            // Validate Items property exists and is an array
            if (!request.TryGetProperty("Items", out JsonElement itemsElement))
            {
                Log.Warning($"{_UserID} Missing Items property in request");
                return Json(new { success = false, message = "No items to transfer" });
            }

            if (itemsElement.ValueKind != JsonValueKind.Array)
            {
                Log.Warning($"{_UserID} Items property is not an array");
                return Json(new { success = false, message = "Invalid items format" });
            }

            var Items = itemsElement.EnumerateArray().ToList();
            
            if (Items.Count == 0)
            {
                Log.Warning($"{_UserID} Empty items array");
                return Json(new { success = false, message = "No items to transfer" });
            }

            // Validate LocationID
            if (!request.TryGetProperty("LocationID", out JsonElement locationElement) || 
                string.IsNullOrWhiteSpace(locationElement.GetString()))
            {
                Log.Warning($"{_UserID} Missing or invalid LocationID");
                return Json(new { success = false, message = "Invalid location" });
            }

            string locationID = locationElement.GetString()!;
            Log.Information($"{_UserID} Processing transfer for location {locationID} with {Items.Count} items");

            var strategy = _context.Database.CreateExecutionStrategy();
            
            return await strategy.ExecuteAsync(async () =>
            {
                using var transaction = await _context.Database.BeginTransactionAsync();
                
                try
                {
                    string transactionNo = GenerateTransactionNo();
                    var errors = new List<string>();
                    var warnings = new List<string>();
                    int successCount = 0;

                    foreach (var transferGroup in Items)
                    {
                        try
                        {
                            // Validate transfer group structure
                            if (!transferGroup.TryGetProperty("fromBinID", out JsonElement fromBinElement) ||
                                !transferGroup.TryGetProperty("toBinID", out JsonElement toBinElement) ||
                                !transferGroup.TryGetProperty("items", out JsonElement itemsInGroup))
                            {
                                errors.Add("Invalid transfer group structure");
                                continue;
                            }

                            int fromBinID = fromBinElement.GetInt32();
                            int toBinID = toBinElement.GetInt32();

                            if (itemsInGroup.ValueKind != JsonValueKind.Array)
                            {
                                errors.Add($"Invalid items format in transfer from bin {fromBinID} to {toBinID}");
                                continue;
                            }

                            // Check if destination bin exists
                            var destinationBinExists = await _context.MultiBatchItemBins
                                .AnyAsync(b => b.BinID == toBinID && b.LocationID == locationID);

                            if (!destinationBinExists)
                            {
                                errors.Add($"Destination bin {toBinID} not found");
                                continue;
                            }

                            foreach (var item in itemsInGroup.EnumerateArray())
                            {
                                try
                                {
                                    // Validate item structure
                                    if (!item.TryGetProperty("itemID", out JsonElement itemIDElement) ||
                                        string.IsNullOrWhiteSpace(itemIDElement.GetString()))
                                    {
                                        errors.Add("Invalid item ID");
                                        continue;
                                    }

                                    string itemID = itemIDElement.GetString()!;

                                    var variants = await _context.MultiBatchBalanceBins
                                        .Where(b => b.LocationID == locationID &&
                                                   b.BinID == fromBinID &&
                                                   b.ItemID == itemID &&
                                                   b.Quantity > 0)
                                        .ToListAsync();

                                    if (!variants.Any())
                                    {
                                        errors.Add($"Item {itemID} not found or out of stock in source bin");
                                        continue;
                                    }

                                    // Transfer each variant
                                    foreach (var sourceBinBalance in variants)
                                    {
                                        await _context.Entry(sourceBinBalance).ReloadAsync();
                                        
                                        if (sourceBinBalance.Quantity <= 0)
                                        {
                                            warnings.Add($"Item {itemID} (Batch: {sourceBinBalance.BatchID}) was depleted by another transaction. Skipped.");
                                            continue;
                                        }

                                        decimal transferQty = sourceBinBalance.Quantity;

                                        var destBinBalance = await _context.MultiBatchBalanceBins
                                            .FirstOrDefaultAsync(b =>
                                                b.LocationID == locationID &&
                                                b.BinID == toBinID &&
                                                b.ItemID == sourceBinBalance.ItemID &&
                                                b.NIE_BPOM == sourceBinBalance.NIE_BPOM &&
                                                b.BatchID == sourceBinBalance.BatchID &&
                                                b.ExpiredDate.Date == sourceBinBalance.ExpiredDate.Date);

                                        if (destBinBalance == null)
                                        {
                                            destBinBalance = new MultiBatchBalanceBin
                                            {
                                                LocationID = locationID,
                                                BinID = toBinID,
                                                ItemID = sourceBinBalance.ItemID,
                                                NIE_BPOM = sourceBinBalance.NIE_BPOM,
                                                BatchID = sourceBinBalance.BatchID,
                                                ExpiredDate = sourceBinBalance.ExpiredDate,
                                                Quantity = 0,
                                                Barcode = sourceBinBalance.Barcode,
                                                LastUpdateUser = _UserID,
                                                LastUpdateDate = DateTime.Now
                                            };
                                            _context.MultiBatchBalanceBins.Add(destBinBalance);
                                            await _context.SaveChangesAsync(); // Save to get ID
                                        }

                                        sourceBinBalance.Quantity = 0;
                                        sourceBinBalance.LastUpdateUser = _UserID;
                                        sourceBinBalance.LastUpdateDate = DateTime.Now;

                                        destBinBalance.Quantity += transferQty;
                                        destBinBalance.LastUpdateUser = _UserID;
                                        destBinBalance.LastUpdateDate = DateTime.Now;

                                        // Create logs
                                        var sourceLog = new MultiBatchBalanceBinLog
                                        {
                                            MultiBatchBalanceBinID = sourceBinBalance.MultiBatchBalanceBinID,
                                            QtyIn = 0,
                                            QtyOut = transferQty,
                                            TransactionNo = transactionNo,
                                            CreatedBy = _UserID,
                                            CreatedDate = DateTime.Now
                                        };
                                        _context.MultiBatchBalanceBinLogs.Add(sourceLog);

                                        var destLog = new MultiBatchBalanceBinLog
                                        {
                                            MultiBatchBalanceBinID = destBinBalance.MultiBatchBalanceBinID,
                                            QtyIn = transferQty,
                                            QtyOut = 0,
                                            TransactionNo = transactionNo,
                                            CreatedBy = _UserID,
                                            CreatedDate = DateTime.Now
                                        };
                                        _context.MultiBatchBalanceBinLogs.Add(destLog);
                                    }

                                    successCount++;
                                }
                                catch (Exception itemEx)
                                {
                                    Log.Error(itemEx, $"{_UserID} Error transferring item");
                                    errors.Add($"Error transferring item: {itemEx.Message}");
                                }
                            }
                        }
                        catch (Exception groupEx)
                        {
                            Log.Error(groupEx, $"{_UserID} Error processing transfer group");
                            errors.Add($"Error processing transfer group: {groupEx.Message}");
                        }
                    }

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    var message = successCount > 0
                        ? $"Successfully transferred {successCount} item(s). Transaction No: {transactionNo}"
                        : "No items were transferred";

                    if (warnings.Any())
                    {
                        message += $"<br/><strong>?? Warnings:</strong> {string.Join("; ", warnings)}";
                    }

                    if (errors.Any())
                    {
                        message += $"<br/><strong>? Errors:</strong> {string.Join("; ", errors)}";
                    }

                    Log.Information($"{_UserID} Transfer completed: {successCount} items transferred, {warnings.Count} warnings, {errors.Count} errors");

                    return Json(new
                    {
                        success = successCount > 0,
                        message,
                        transferredItemsCount = successCount,
                        warnings = warnings.Any() ? warnings : null,
                        errors = errors.Any() ? errors : null,
                        transactionNo
                    });
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    Log.Error(ex, $"{_UserID} Error in {nameof(ProcessTransfer)}");
                    return Json(new
                    {
                        success = false,
                        message = "Failed to process transfer. Please try again or contact IT."
                    });
                }
            });
        }

        #endregion

        #region Helper Methods

        private string GenerateTransactionNo()
        {
            return $"BT/{DateTime.Now:yyMMdd}-{DateTime.Now:HHmmss}{new Random().Next(0, 999):D3}";
        }

        #endregion
    }
}