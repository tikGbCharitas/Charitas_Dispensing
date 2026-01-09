using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using AvicennaDispensing.Models;
using AvicennaDispensing.ViewModels;
using AvicennaDispensing.ViewModels.Shared;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Text.Json;
using static AvicennaDispensing.ViewModels.InventoryBinViewModel;
using static AvicennaDispensing.ViewModels.OpenBatchViewModel;

namespace AvicennaDispensing.Controllers
{
    public class InventoryBinController : BaseController
    {
        public InventoryBinController(ApplicationDbContext context) : base(context)
        {
            
        }

        #region Bin Stock

        #region General
        public async Task<IActionResult> Index(string? LocID, AppEnum.DataMode md = AppEnum.DataMode.View, string? searchQuery = null)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)} with Argument {LocID} and Search for {searchQuery}");
            
            if( md == AppEnum.DataMode.Edit)
            {
                onEdit();
            }
            else
            {
                onView();
            }

            var viewmodel = new IndexViewModel();
            viewmodel.Locations = new LocationViewModel();

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
                                                    }
                                                    ).ToList();
                viewmodel.Locations.LocationList = LocationList;
            }

            if (!string.IsNullOrWhiteSpace(LocID))
            {
                viewmodel.Items = await GetData(LocID, searchQuery);
                viewmodel.Locations.SelectedLocationID = LocID;
                viewmodel.Locations.SelectedLocationName = (await _context.Locations.FirstOrDefaultAsync(a => a.LocationID == LocID))!.LocationName;
            }
            ViewBag.Search = searchQuery;
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)} with return data {JsonSerializer.Serialize(viewmodel)}");
            return View(viewmodel);
        }
        public async Task<IActionResult> SearchItemsBinStock(string? LocID, string? searchQuery = "", bool onViewMode = true)
        {
            Log.Information($"{_UserID} AJAX Search: LocID={LocID}, Query={searchQuery}");

            try
            {
                var viewModel = await GetData(LocID, searchQuery);

                if (onViewMode)
                {
                    onView();
                }
                else
                {
                    onEdit();
                }

                ViewBag.Search = searchQuery;

                // Return HTML partial view instead of JSON
                // This is rendered server-side with all Razor helpers, localization, etc.
                return PartialView("_CollectionBinStock", viewModel);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"{_UserID} Error in AJAX search");

                // Return error partial view
                return PartialView("_SearchError", new { Message = "An error occurred while searching. Please try again." });
            }
        }
        private async Task<List<ItemList>> GetData(string? LocationID, string? searchQuery = null)
        {
            var query = await (
                                from mbblcb in _context.MultiBatchBalanceBins.AsNoTracking()
                                join i in _context.Items.AsNoTracking() on mbblcb.ItemID equals i.ItemID
                                join mbib in _context.MultiBatchItemBins.AsNoTracking() on mbblcb.BinID equals mbib.BinID
                                join mbblc in _context.MultiBatchBalances.AsNoTracking() on new
                                {
                                    mbblcb.LocationID,
                                    mbblcb.ItemID,
                                    mbblcb.NIE_BPOM,
                                    mbblcb.BatchID,
                                    mbblcb.ExpiredDate
                                }
                                equals new
                                {
                                    mbblc.LocationID,
                                    mbblc.ItemID,
                                    mbblc.NIE_BPOM,
                                    mbblc.BatchID,
                                    mbblc.ExpiredDate
                                }
                                where mbblcb.LocationID == LocationID
                                select new InventoryBinViewModel.ItemList
                                {
                                    MultiBatchBalanceBinID = mbblcb.MultiBatchBalanceBinID,
                                    BinName = mbib.BinName,
                                    ItemID = mbblcb.ItemID,
                                    ItemName = i.ItemName,
                                    NIE_BPOM = mbblcb.NIE_BPOM,
                                    BatchID = mbblcb.BatchID,
                                    ExpiredDate = mbblcb.ExpiredDate.Date.ToString(),
                                    BinQty = mbblcb.Quantity,
                                    MaxBinQty = mbblc.Balance,
                                    Barcode  = mbblcb.Barcode,
                                    isOpen = mbblc.isOpen,
                                }
                                )
                                .ToListAsync();

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                searchQuery = searchQuery.Trim().Substring(0, Math.Min(30, searchQuery.Trim().Length));
                var lowerSearchQuery = searchQuery.ToLower();

                // Check if search query is a barcode (length >= 30)
                if (searchQuery.Length >= 30)
                {
                    query = query.Where(item =>
                        !string.IsNullOrEmpty(item.Barcode) && item.Barcode.ToLower().Contains(lowerSearchQuery)
                    ).ToList();
                }
                else
                {
                    // Search across multiple fields
                    query = query.Where(item =>
                        item.ItemID.ToLower().Contains(lowerSearchQuery) ||
                        item.NIE_BPOM!.ToLower().Contains(lowerSearchQuery) ||
                        item.BatchID!.ToLower().Contains(lowerSearchQuery) ||
                        item.ItemName!.ToLower().Contains(lowerSearchQuery) ||
                        (item.BinName ?? string.Empty).ToLower().Contains(lowerSearchQuery) ||
                        (item.Barcode ?? string.Empty).ToLower().Contains(lowerSearchQuery)
                    ).ToList();
                }
            }
            else
            {
                query = query.OrderBy(a => a.ExpiredDate).Take(100).ToList();
            }


            return query;
        }

        #endregion

        #region CRUD Operation

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cancel(string toolbarData)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Cancel)} with Argument {toolbarData}");

            if (string.IsNullOrWhiteSpace(toolbarData))
            {
                Log.Warning($"{_UserID} {nameof(Cancel)} called with null or empty toolbarData");
                return RedirectToAction("Index");
            }

            JsonElement parsedData;
            try
            {
                parsedData = JsonSerializer.Deserialize<JsonElement>(toolbarData);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Invalid JSON format: {ex.Message}";
                Log.Error(ex, $"{_UserID} Accessing {_ControllerName} on method {nameof(Cancel)} with invalid JSON format: {toolbarData}");
                onSaveCancel();
                return RedirectToAction("Index");
            }

            string? LocationID = parsedData.GetProperty("LocationID").GetString();
            string? SearchQuery = parsedData.GetProperty("SearchQuery").GetString();

            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Cancel)} and Redirect To {nameof(Index)}");
            
            return RedirectToAction("Index", new 
            { 
                LocID = LocationID,
                md = AppEnum.DataMode.View,
                searchQuery = SearchQuery
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string toolbarData)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Edit)} with Argument {toolbarData}");

            if (string.IsNullOrWhiteSpace(toolbarData))
            {
                Log.Warning($"{_UserID} {nameof(Edit)} called with null or empty toolbarData");
                return RedirectToAction("Index");
            }

            JsonElement parsedData;
            try
            {
                parsedData = JsonSerializer.Deserialize<JsonElement>(toolbarData);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Invalid JSON format: {ex.Message}";
                Log.Error(ex, $"{_UserID} Accessing {_ControllerName} on method {nameof(Edit)} with invalid JSON format: {toolbarData}");
                onSaveCancel();
                return RedirectToAction("Index");
            }

            string? LocationID = parsedData.GetProperty("LocationID").GetString();
            string? SearchQuery = parsedData.GetProperty("SearchQuery").GetString();

            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Edit)} and Redirect To {nameof(Index)}");
            return RedirectToAction("Index", new 
            { 
                LocID = LocationID, 
                md = AppEnum.DataMode.Edit,
                searchQuery = SearchQuery
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(string toolbarData)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with Argument {toolbarData}");
            JsonElement parsedData;
            try
            {
                parsedData = JsonSerializer.Deserialize<JsonElement>(toolbarData);
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = $"Invalid JSON format: {ex.Message}";
                Log.Error(ex, $"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with invalid JSON format: {toolbarData}");
                onSaveCancel();
                return View("Index");
            }

            string LocationID = parsedData.GetProperty("LocID").GetString()!;

            parsedData.TryGetProperty("SearchQuery", out JsonElement searchQueryProp);
            string? searchQuery = searchQueryProp.ValueKind == JsonValueKind.String ? searchQueryProp.GetString() : null;

            if (!parsedData.TryGetProperty("Datas", out var datasProp))
            {
                ViewBag.ErrorMessage = $"Invalid data: Datas are missing from JSON";
                onEdit();
                Log.Error($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with invalid data: Datas are missing from JSON: {toolbarData}");
                var inventoryBin = await GetData(LocationID, searchQuery);
                return View("Index", inventoryBin);
            }

            string TransactionNo = "IB/" + DateTime.Now.ToString("yyMMdd") + "-" + DateTime.Now.ToString("HHmmss") + new Random().Next(0, 999).ToString("D3");
            var coll = datasProp.EnumerateArray();
            foreach (var data in coll)
            {
                int MultiBatchBalanceBinID = data.GetProperty("MultiBatchBalanceBinID").GetInt32();
                bool isUnlock = false;
                if(data.TryGetProperty("isUnlock", out JsonElement _isUnlock))
                {
                    if (_isUnlock.ValueKind == JsonValueKind.True)
                        isUnlock = true;
                    else if (_isUnlock.ValueKind == JsonValueKind.False)
                        isUnlock = false;
                }

                var dataexist = _context.MultiBatchBalanceBins
                                        .AsEnumerable()
                                        .FirstOrDefault(a => a.MultiBatchBalanceBinID == MultiBatchBalanceBinID);

                if (dataexist != null)
                {
                    decimal NewQty, OldQty;

                    var EditBinQtyProp = data.GetProperty("EditBinQty");
                    if (EditBinQtyProp.ValueKind == JsonValueKind.Number)
                        NewQty = EditBinQtyProp.GetDecimal();
                    else if (EditBinQtyProp.ValueKind == JsonValueKind.String &&
                             decimal.TryParse(EditBinQtyProp.GetString(), out var parsed))
                        NewQty = parsed;
                    else
                        NewQty = 0;

                    var binQtyProp = data.GetProperty("BinQty");
                    if (binQtyProp.ValueKind == JsonValueKind.Number)
                        OldQty = binQtyProp.GetDecimal();
                    else if (binQtyProp.ValueKind == JsonValueKind.String &&
                             decimal.TryParse(binQtyProp.GetString(), out var parsed))
                        OldQty = parsed;
                    else
                        OldQty = 0;

                    dataexist.Quantity = NewQty;

                    if (isUnlock)
                    {
                        var mbbb = await _context.MultiBatchBalances.FirstOrDefaultAsync(a => a.LocationID == LocationID && a.ItemID == dataexist.ItemID &&
                                        a.NIE_BPOM == dataexist.NIE_BPOM && a.BatchID == dataexist.BatchID && a.ExpiredDate.Date == dataexist.ExpiredDate.Date);
                        mbbb!.isOpen = true;
                        mbbb.LastTransactionNo = TransactionNo;
                        mbbb.LastUpdateByid = _UserID;
                        mbbb.LastUpdateByTime = DateTime.Now;
                        mbbb.Balance -= (NewQty - OldQty);
                    }

                    var mbib = new MultiBatchInventoryBin();
                    mbib.TransactionNo = TransactionNo;
                    mbib.MultiBatchBalanceBinID = MultiBatchBalanceBinID;
                    mbib.FromQty = OldQty;
                    mbib.ToQty = NewQty;
                    mbib.LastUpdatebyTime = DateTime.Now;
                    mbib.LastUpdatebyID = _UserID;
                    _context.MultiBatchInventoryBins.Add(mbib);

                    var mbbblog = new MultiBatchBalanceBinLog();
                    mbbblog.MultiBatchBalanceBinID = MultiBatchBalanceBinID;
                    if (NewQty > OldQty)
                    {
                        mbbblog.QtyIn = NewQty - OldQty;
                        mbbblog.QtyOut = 0;
                    }
                    else
                    {
                        mbbblog.QtyIn = 0;
                        mbbblog.QtyOut = OldQty - NewQty;
                    }
                    mbbblog.CreatedBy = _UserID;
                    mbbblog.CreatedDate = DateTime.Now;
                    mbbblog.TransactionNo = TransactionNo;
                    _context.MultiBatchBalanceBinLogs.Add(mbbblog);
                }
            }
            _context.SaveChanges();

            onSaveCancel();
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} and Redirect To {nameof(Index)} with Location {LocationID} and search for {searchQuery}");
            return RedirectToAction("Index", new { LocID = LocationID, searchQuery });
        }

        #endregion

        #endregion

        #region Bin Master
        public async Task<IActionResult> BinMasterIndex(string? LocID)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(BinMasterIndex)} with Argument {LocID}");
            BinMasterViewModel? viewmodel = new BinMasterViewModel();
            
            string? LocationArray = User.FindFirst(ClaimTypesCustom.Service_Unit)?.Value;

            if (!string.IsNullOrWhiteSpace(LocationArray))
            {
                viewmodel.Locations ??= new LocationViewModel();
                viewmodel.Locations.ActionRoute = nameof(BinMasterIndex);
                
                var LocationIDList = LocationArray.Split('|');
                var LocationList = _context.Locations.AsEnumerable()
                                            .Where(a => LocationIDList.Contains(a.LocationID))
                                            .Select(x => new LocationViewModel.LocationsDetail
                                            {
                                                LocationID = x.LocationID,
                                                LocationName = x.LocationName
                                            }
                                            ).ToList();
                viewmodel.Locations.LocationList = LocationList;

                if (LocID != null && !string.IsNullOrWhiteSpace(LocID))
                {
                    viewmodel.Locations.SelectedLocationID = LocID;
                    viewmodel.Locations.SelectedLocationName = (await _context.Locations.FirstOrDefaultAsync(a => a.LocationID == LocID))!.LocationName;
                    viewmodel.Bins = await GetBinList(LocID);
                }
            }

            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(BinMasterIndex)} with return data {JsonSerializer.Serialize(viewmodel)}");
            return View("BinMasterIndex", viewmodel);
        }

        private async Task<List<MultiBatchItemBin>> GetBinList(string SelectedLocationID, string? searchQuery = "")
        {
            var binList = await _context.MultiBatchItemBins
                                        .Where(a => a.LocationID == SelectedLocationID)
                                        .OrderBy(a => a.BinName)
                                        .ToListAsync();
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                searchQuery = searchQuery.Trim().ToUpper();
                binList = binList.Where(a => a.BinName.Contains(searchQuery)).ToList();
            }

            return binList;
        }
        
        public async Task<IActionResult> SearchBinMaster(string? LocID, string? searchQuery = "")
        {
            Log.Information($"{_UserID} AJAX Search Bin Master: LocID={LocID}, Query={searchQuery}");
            try
            {
                var binList = await GetBinList(LocID!, searchQuery);

                var viewmodel = new BinMasterViewModel
                {
                    Bins = binList
                };

                // Return HTML partial view instead of JSON
                return PartialView("_CollectionBinMaster", viewmodel);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"{_UserID} Error in AJAX search for Bin Master");
                // Return error partial view
                return PartialView("_SearchError", new { Message = "An error occurred while searching. Please try again." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBin([FromBody] JsonElement request)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(AddBin)} with Argument {request}");
            List<string> BinSaved = new(); List<string> BinNameExist = new();
            List<string> BinDuplicate = new(); // ✅ Track duplikat dalam request
            HashSet<string> processedBins = new(); // ✅ Track bins yang sudah diproses
            string LocationID = request.GetProperty("LocID").GetString()!;
            var Coll = request.GetProperty("Coll").EnumerateArray();

            foreach (var BinName in Coll)
            {
                string BinNameUpper = BinName.ToString().Trim().ToUpper();

                if (processedBins.Contains(BinNameUpper))
                {
                    BinDuplicate.Add(BinNameUpper);
                    continue;
                }

                var BinExist = await _context.MultiBatchItemBins.AnyAsync(a => a.BinName == BinNameUpper && a.LocationID == LocationID);
                if (!BinExist)
                {
                    var newBin = new MultiBatchItemBin();
                    newBin.BinName = BinNameUpper;
                    newBin.LocationID = LocationID!;
                    newBin.LastUpdateDate = DateTime.Now;
                    newBin.LastUpdateUser = _UserID;
                    newBin.CreatedDate = DateTime.Now;
                    newBin.CreatedBy = _UserID;

                    BinSaved.Add(BinNameUpper);
                    processedBins.Add(BinNameUpper);
                    _context.MultiBatchItemBins.Add(newBin);
                }
                else
                {
                    BinNameExist.Add(BinNameUpper);
                }
            }
            await _context.SaveChangesAsync();

            var payload = new
            {
                success = true,
                redirect = Url.Action("BinMasterIndex", new { SelectedLocationID = LocationID }),
                data = new
                {
                    saved = BinSaved,
                    exist = BinNameExist,
                    duplicate = BinDuplicate
                }
            };
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(AddBin)} with return data {payload}");
            return Json(payload);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeBinNameUrl([FromBody]JsonElement request)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(ChangeBinNameUrl)} with Argument {request}");
            string LocID = request.GetProperty("LocID").GetString()!.Trim();
            string BinID = request.GetProperty("BinID").GetString()!.Trim();
            string NewBinName = request.GetProperty("NewBinName").GetString()!.ToUpper().Trim();

            var BinNameExist = await _context.MultiBatchItemBins.FirstOrDefaultAsync(a => a.LocationID == LocID && a.BinName == NewBinName);

            if(BinNameExist != null)
            {
                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(ChangeBinNameUrl)} {NewBinName} already exist on database on Location {LocID}");
                return Json(new { success = false, message = $"BinName {NewBinName} already exist on this location" });
            }

            var existing = await _context.MultiBatchItemBins
                .FirstOrDefaultAsync(a => a.LocationID == LocID && a.BinID.ToString() == BinID);

            if(existing != null)
            {
                existing.BinName = NewBinName;
                existing.LastUpdateUser = _UserID;
                existing.LastUpdateDate = DateTime.Now;

                await _context.SaveChangesAsync();
                var response = new
                {
                    success = true,
                    BinName = NewBinName
                };

                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(ChangeBinNameUrl)} with return data {response}");
                return Json(response);
            }
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(ChangeBinNameUrl)} with return failed to Rename Bin with Unknown Error");
            return Json(new { success = false, message = "Unknown Error: Please contact IT Department" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBin([FromBody] JsonElement request)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(DeleteBin)} with Argument {request}");
            
            try
            {
                string LocID = request.GetProperty("LocID").GetString()!.Trim();
                string SearchQuery = request.GetProperty("SearchQuery").GetString() ?? string.Empty;
                var binNamesRaw = request.GetProperty("BinNames").GetString();

                if (string.IsNullOrWhiteSpace(LocID) || string.IsNullOrWhiteSpace(binNamesRaw))
                {
                    Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(DeleteBin)} returning Invalid request data");
                    return Json(new { success = false, message = "Invalid request data." });
                }

                var binNames = binNamesRaw
                        .Split(';', StringSplitOptions.RemoveEmptyEntries)
                        .Select(b => b.Trim())
                        .Distinct()
                        .ToList();

                var binNameSet = new HashSet<string>(binNames.Select(x => x.ToUpperInvariant()));
                var bins = await _context.MultiBatchItemBins
                    .Where(b => b.LocationID == LocID)
                    .Select(b => new { b.BinID, b.BinName })
                    .ToListAsync();

                bins = bins
                    .Where(b => !string.IsNullOrWhiteSpace(b.BinName) && binNameSet.Contains(b.BinName.Trim().ToUpperInvariant()))
                    .ToList();

                if (!bins.Any())
                {
                    Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(DeleteBin)} returning No bins found");
                    return Json(new { success = false, message = "No bins found." });
                }

                var binIds = bins.Select(b => b.BinID).ToList();
                var usedBinIds = new HashSet<int>();

                var allBatchBinIds = await _context.MultiBatches
                                    .Where(x => x.BinID.HasValue)
                                    .Select(x => x.BinID!.Value)
                                    .Distinct()
                                    .ToListAsync();
                var batchBinIds = allBatchBinIds.Intersect(binIds).ToList();

                var allBalanceBinIds = await _context.MultiBatchBalanceBins
                    .Select(x => x.BinID)
                    .Distinct()
                    .ToListAsync();
                var balanceBinIds = allBalanceBinIds.Intersect(binIds).ToList();

                var allTempBinIds = await _context.MultiBatchTemps
                    .Where(x => x.BinID.HasValue)
                    .Select(x => x.BinID!.Value)
                    .Distinct()
                    .ToListAsync();
                var tempBinIds = allTempBinIds.Intersect(binIds).ToList();

                usedBinIds.UnionWith(batchBinIds);
                usedBinIds.UnionWith(balanceBinIds);
                usedBinIds.UnionWith(tempBinIds);

                var failedBins = bins
                                   .Where(b => usedBinIds.Contains(b.BinID))
                                   .Select(b => b.BinName)
                                   .ToList();

                var deletableBins = bins
                                    .Where(b => !usedBinIds.Contains(b.BinID))
                                    .ToList();

                if (!deletableBins.Any())
                {
                    Log.Warning("{User} Cannot delete bins {Bins}", _UserID, string.Join(", ", failedBins));
                    return Json(new
                    {
                        success = false,
                        message = $"Cannot remove bin: {string.Join(", ", failedBins)} because has been used"
                    });
                }

                var deletableBinIds = deletableBins.Select(x => x.BinID).ToList();

                using var transaction = await _context.Database.BeginTransactionAsync();

                try
                {
                    var entities = await _context.MultiBatchItemBins
                                        .Where(b => deletableBinIds.Contains(b.BinID))
                                        .ToListAsync();

                    _context.MultiBatchItemBins.RemoveRange(entities);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();
                }
                catch (DbUpdateException dbEx)
                {
                    await transaction.RollbackAsync();

                    Log.Error(dbEx,
                        "{User} Failed to delete bins due to database constraint",
                        _UserID);

                    return Json(new
                    {
                        success = false,
                        message = "Delete failed because the bin is currently in use."
                    });
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();

                    Log.Error(ex,
                        "{User} Failed to delete bins due to unexpected error",
                        _UserID);

                    return Json(new
                    {
                        success = false,
                        message = "Failed to delete bin. Please try again or contact IT."
                    });
                }

                var binList = await GetBinList(LocID!, SearchQuery);

                var viewmodel = new BinMasterViewModel
                {
                    Bins = binList
                };

                var html = await this.RenderPartialViewToStringAsync("_CollectionBinMaster", viewmodel);

                var deletedBinName = string.Join(", ", deletableBins.Select(b => b.BinName));

                if (failedBins.Any())
                {
                    Log.Warning($"{_UserID} Some bins could not be deleted: {string.Join(", ", failedBins)}");
                    return Json(new
                    {
                        success = true,
                        message = $"Success remove bin: {deletedBinName}.<br>" +
                                    $"Cannot remove bin: {string.Join(", ", failedBins)}",
                        html
                    });
                }

                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(DeleteBin)} with return data {deletedBinName}");
                return Json(new
                {
                    success = true,
                    message = $"Success remove bin: {deletedBinName}",
                    html
                });
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"{_UserID} Error in {nameof(DeleteBin)}");
                return Json(new 
                { 
                    success = false, 
                    message = "An error occurred while deleting bins. Please contact IT Department." 
                });
            }
        }
        #endregion
    }
}
