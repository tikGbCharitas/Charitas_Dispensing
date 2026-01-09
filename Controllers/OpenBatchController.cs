using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using AvicennaDispensing.Models;
using AvicennaDispensing.ViewModels;
using AvicennaDispensing.ViewModels.Shared;
using OpenBatchResources = AvicennaDispensing.Resources.Views.OpenBatch;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Serilog;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using static AvicennaDispensing.ViewModels.OpenBatchViewModel;

namespace AvicennaDispensing.Controllers
{
    public class OpenBatchController : BaseController
    {
        private readonly IStringLocalizer _sharedlocalizer;
        private readonly IStringLocalizer<OpenBatchResources.Index> _localizer;
        
        public OpenBatchController(ApplicationDbContext context, IStringLocalizerFactory localizerFactory, IStringLocalizer<OpenBatchResources.Index> localizer) : base(context) 
        {
            _sharedlocalizer = localizerFactory.Create("Views.Shared.Common", Assembly.GetExecutingAssembly().GetName().Name!);
            _localizer = localizer;
        }

        #region General

        public async Task<IActionResult> Index(string? LocID, AppEnum.DataMode md = AppEnum.DataMode.View, string SelectionType = "Location", string? TransactionNo = null, string? searchQuery = null)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)} with Argument {LocID} on {md} mode and Selection Type {SelectionType} with TransactionNo {TransactionNo} and SearchQuery {searchQuery}");
            OpenBatchViewModel viewModel = new OpenBatchViewModel();
            // Set mode based on query string parameter
            if ( md == AppEnum.DataMode.Edit)
            {
                onEdit();
            }
            else
            {
                onView();
            }

            (viewModel, LocID) = await GetOpenBatch(SelectionType, LocationID: LocID ?? string.Empty, TransactionNo: TransactionNo ?? string.Empty, searchQuery: searchQuery);
            viewModel.SelectionType = SelectionType;
            viewModel.Locations ??= new LocationViewModel();
            viewModel.Locations.SelectedLocationID = LocID;
            var location = await _context.Locations.FirstOrDefaultAsync(a => a.LocationID == LocID);
            viewModel.Locations.SelectedLocationName = location?.LocationName;

            string? LocationArray = User.FindFirst(ClaimTypesCustom.Service_Unit)?.Value;
            if (!string.IsNullOrWhiteSpace(LocationArray))
            {
                viewModel.Locations ??= new LocationViewModel();
                var LocationIDList = LocationArray.Split('|');
                var LocationList = _context.Locations.AsEnumerable()
                                                    .Where(a => LocationIDList.Contains(a.LocationID))
                                                    .Select(x => new LocationViewModel.LocationsDetail
                                                    {
                                                        LocationID = x.LocationID,
                                                        LocationName = x.LocationName
                                                    }
                                                    ).ToList();
                viewModel.Locations.LocationList = LocationList;
            }

            ViewBag.TransactionNo = TransactionNo;
            ViewBag.Search = searchQuery;
            ViewBag.Error = ViewBag.Error ?? TempData["Error"] ?? null;
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)} with return data {JsonSerializer.Serialize(viewModel)}");
            return View(viewModel);
        }

        public async Task<IActionResult> SearchItems(string? LocID, string SelectionType = "Location", string? TransactionNo = null, string? searchQuery = "", bool onViewMode = true)
        {
            Log.Information($"{_UserID} AJAX Search: LocID={LocID}, Type={SelectionType}, TransNo={TransactionNo}, Query={searchQuery}");
            
            try
            {
                var (viewModel, locationId) = await GetOpenBatch(
                    SelectionType, 
                    LocationID: LocID ?? string.Empty, 
                    TransactionNo: TransactionNo ?? string.Empty, 
                    searchQuery: searchQuery ?? string.Empty
                );

                if (onViewMode)
                {
                    onView();
                }
                else
                {
                    onEdit();
                }

                ViewBag.Search = searchQuery;
                viewModel.SelectionType = SelectionType;

                // Return HTML partial view instead of JSON
                // This is rendered server-side with all Razor helpers, localization, etc.
                return PartialView("_Collection", viewModel);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"{_UserID} Error in AJAX search");
                
                // Return error partial view
                return PartialView("_SearchError", new { Message = _sharedlocalizer["AnErrorOccurred"] });
            }
        }

        private async Task<(OpenBatchViewModel, string?)> GetOpenBatch(string SelectionType, string? LocationID, string? TransactionNo = null, string? searchQuery = null)
        {
            OpenBatchViewModel ViewModel = new OpenBatchViewModel();
            switch (SelectionType)
            {
                case "Location":
                    if (string.IsNullOrWhiteSpace(LocationID))
                    {
                        Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetOpenBatch)} on case {SelectionType} with {LocationID}");
                        break;
                    }

                    var binData = await _context.MultiBatchBalanceBins.AsNoTracking()
                                    .Where(a => a.LocationID == LocationID && a.Quantity > 0)
                                    .Join(_context.MultiBatchItemBins,
                                            mbbb => mbbb.BinID,
                                            mbib => mbib.BinID,
                                            (mbbb, mbib) => new { mbbb, mbib.BinName })
                                    .GroupBy(b => new { b.mbbb.ItemID, b.mbbb.NIE_BPOM, b.mbbb.BatchID, b.mbbb.ExpiredDate.Date, b.mbbb.LocationID, b.mbbb.BinID, b.BinName, b.mbbb.Barcode })
                                    .Select(g => new
                                    {
                                        g.Key.ItemID,
                                        g.Key.NIE_BPOM,
                                        g.Key.BatchID,
                                        g.Key.Date,
                                        g.Key.LocationID,
                                        g.Key.BinID,
                                        g.Key.BinName,
                                        g.Key.Barcode,
                                        TotalQuantity = g.Sum(x => x.mbbb.Quantity)
                                    })
                                    .ToListAsync();

                    var mbblcData = await (
                                            from mbblc in _context.MultiBatchBalances.AsNoTracking()
                                            join i in _context.Items.AsNoTracking() on mbblc.ItemID equals i.ItemID
                                            join l in _context.Locations.AsNoTracking() on mbblc.LocationID equals l.LocationID
                                            join ipm in _context.ItemProductMedics.AsNoTracking() on mbblc.ItemID equals ipm.ItemID
                                            where mbblc.LocationID == LocationID && mbblc.Balance > 0
                                            orderby mbblc.isOpen ascending, mbblc.ExpiredDate descending, mbblc.ItemID ascending
                                            select new
                                            {
                                                mbblc,
                                                i.ItemName,
                                                l.LocationName,
                                                ipm.ConversionFactor
                                            }
                                            ).ToListAsync();

                    var queryItemDetail = (
                                            from mb in mbblcData
                                            join bin in binData on new
                                            {
                                                mb.mbblc.ItemID,
                                                mb.mbblc.NIE_BPOM,
                                                mb.mbblc.BatchID,
                                                mb.mbblc.ExpiredDate.Date,
                                                mb.mbblc.LocationID
                                            }
                                            equals new
                                            {
                                                bin.ItemID,
                                                bin.NIE_BPOM,
                                                bin.BatchID,
                                                bin.Date,
                                                bin.LocationID
                                            }
                                            into binJoin
                                            from bin in binJoin.DefaultIfEmpty()
                                            select new ItemDetailViewModel
                                            {
                                                ItemID = mb.mbblc.ItemID,
                                                BatchID = mb.mbblc.BatchID,
                                                Balance = mb.mbblc.Balance ?? 0,
                                                ExpiredDate = mb.mbblc.ExpiredDate.ToString("yyyy-MM-dd"),
                                                NIE_BPOM = mb.mbblc.NIE_BPOM,
                                                isOpen = mb.mbblc.isOpen,
                                                Barcode = mb.mbblc.Barcode,

                                                ConvertionFactor = mb.ConversionFactor,
                                                ItemName = mb.ItemName,
                                                LocationName = mb.LocationName,

                                                BinQty = bin?.TotalQuantity ?? 0,
                                                BinName = bin?.BinName,
                                                BinID = bin?.BinID
                                            }
                                            ).ToList();

                    if (!string.IsNullOrWhiteSpace(searchQuery))
                    {
                        searchQuery = searchQuery.Trim().Substring(0, Math.Min(30, searchQuery.Trim().Length));
                        var lowerSearchQuery = searchQuery.ToLower();
                        
                        // Check if search query is a barcode (length >= 30)
                        if (searchQuery.Length >= 30)
                        {
                            queryItemDetail = queryItemDetail.Where(item =>
                                !string.IsNullOrEmpty(item.Barcode) && item.Barcode.ToLower().Contains(lowerSearchQuery)
                            ).ToList();
                        }
                        else
                        {
                            // Search across multiple fields
                            queryItemDetail = queryItemDetail.Where(item =>
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
                        queryItemDetail = queryItemDetail.OrderBy(a => a.ExpiredDate).Take(100).ToList();
                    }

                    ViewModel.ItemDetail = queryItemDetail;
                    break;

                case "TransactionNo":
                    string ToLocName = string.Empty;
                    ViewModel.ItemDetail = new List<ItemDetailViewModel>();

                    var Entity = await _context.ItemTransactions.AsNoTracking()
                                            .Join(_context.Locations.AsNoTracking(),
                                                    it => it.ToLocationID,
                                                    l => l.LocationID,
                                                    (it, l) => new { it, l.LocationName })
                                            .FirstOrDefaultAsync(a => a.it.TransactionNo == TransactionNo);
                    if (Entity == null)
                    {
                        Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetOpenBatch)} with case {SelectionType} and TransactionNo is not exist");
                        ViewBag.Error = _sharedlocalizer["TransactionNoNotFound"];
                        break;
                    }

                    else
                    {
                        if (string.IsNullOrWhiteSpace(Entity.it.ToLocationID))
                        {
                            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetOpenBatch)} with case {SelectionType} and TransactionNo doesn't have Location");
                            ViewBag.Error = _localizer["TransactionNoDoesntHaveLocation"];
                            break;
                        }
                        LocationID = Entity.it.ToLocationID;
                        ToLocName = Entity.LocationName;
                        Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetOpenBatch)} with case {SelectionType} and Location is change into ID:{LocationID} [{ToLocName}] ");
                    }

                    var coll = _context.MultiBatches.AsNoTracking().Where(a => a.TransactionNo == TransactionNo && a.Status == AppEnum.Status.APPROVE.ToString());

                    if (coll.Count() < 1)
                    {
                        Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetOpenBatch)} with case {SelectionType} and TransactionNo not found or not approved yet");
                        ViewBag.Error = _sharedlocalizer["TransactionNoNotApprovedYet"];
                        break;
                    }

                    var mbbbl = await _context.MultiBatchBalanceBinLogs.AsNoTracking()
                                        .Where(a => a.TransactionNo == TransactionNo)
                                        .ToListAsync();

                    foreach (var item in coll)
                    {
                        var row = new ItemDetailViewModel()
                        {
                            ItemID = item.ItemID!,
                            NIE_BPOM = item.NIE_BPOM,
                            BatchID = item.BatchID,
                            ExpiredDate = item.ExpiredDate?.ToString("yyyy-MM-dd") ?? string.Empty,
                            Balance = item.Quantity,
                            Barcode = item.Barcode,
                            LocationName = ToLocName,
                            SRUnit = item.SRItemUnit
                        };

                        var query = await _context.Items.AsNoTracking()
                                                .Join(_context.ItemProductMedics, 
                                                    i => i.ItemID,
                                                    ipm => ipm.ItemID,
                                                    (i, ipm) => new { i.ItemID, i.ItemName, ipm.ConversionFactor, ipm.SRPurchaseUnit, ipm.SRItemUnit }
                                                    )
                                                .FirstOrDefaultAsync(a => a.ItemID == item.ItemID);

                        bool isOpen = (await _context.MultiBatchBalances.AsNoTracking()
                                        .FirstOrDefaultAsync(a => a.LocationID == LocationID && a.ItemID == item.ItemID && a.NIE_BPOM == item.NIE_BPOM && a.BatchID == item.BatchID && a.ExpiredDate == item.ExpiredDate))?
                                        .isOpen ?? false;

                        row.ItemName = query!.ItemName;
                        row.ConvertionFactor = query.ConversionFactor;
                        row.SRPurchaseUnit = query.SRPurchaseUnit;
                        row.SRItemUnit = query.SRItemUnit;
                        row.isOpen = isOpen;

                        var mbbb = await _context.MultiBatchBalanceBins.AsNoTracking()
                                        .Join(_context.MultiBatchItemBins.AsNoTracking(),
                                            mbbb => mbbb.BinID,
                                            mbib => mbib.BinID,
                                            (mbbb, mbib) => new { mbbb, mbib.BinName }
                                            )
                                        .FirstOrDefaultAsync(a => a.mbbb.LocationID == LocationID && a.mbbb.ItemID == item.ItemID && a.mbbb.NIE_BPOM == item.NIE_BPOM && a.mbbb.BatchID == item.BatchID && a.mbbb.ExpiredDate == item.ExpiredDate);
                        
                        if (mbbb != null)
                        {
                            row.BinID = mbbb.mbbb.BinID;
                            row.BinName = mbbb.BinName;
                            row.BinQty = mbbb.mbbb.Quantity;
                        }
                        else
                        {
                            var mbbbbin = await _context.MultiBatchBalanceBins.AsNoTracking()
                                        .Join(_context.MultiBatchItemBins.AsNoTracking(),
                                            mbbb => mbbb.BinID,
                                            mbib => mbib.BinID,
                                            (mbbb, mbib) => new { mbbb, mbib.BinName }
                                            )
                                        .FirstOrDefaultAsync(a => a.mbbb.LocationID == LocationID && a.mbbb.ItemID == item.ItemID);
                            if(mbbbbin != null)
                            {
                                row.BinID = mbbbbin.mbbb.BinID;
                                row.BinName = mbbbbin.BinName;
                            }
                        }

                        #region Not Implemented
                        // This region for check how many qty is open from TransactionNo
                        // Current build is check if exist then reject editing
                        if (mbbbl != null && mbbbl.Any())
                        {
                            var mbbblLog = mbbbl.Join(_context.MultiBatchBalanceBins.AsNoTracking(),
                                                    mbbbl => mbbbl.MultiBatchBalanceBinID,
                                                    mbbb => mbbb.MultiBatchBalanceBinID,
                                                    (mbbbl, mbbb) => new { mbbbl, mbbb }
                                                    )
                                                .Where(a => a.mbbb.LocationID == LocationID && a.mbbb.ItemID == item.ItemID && a.mbbb.NIE_BPOM == item.NIE_BPOM && a.mbbb.BatchID == item.BatchID && a.mbbb.ExpiredDate == item.ExpiredDate);
                            if (mbbblLog != null && mbbblLog.Any())
                            {
                                row.OpenQty = mbbblLog.Sum(a => a.mbbbl.QtyIn);
                            }
                        }
                        #endregion

                        ViewModel.ItemDetail.Add(row);
                    }

                    // Server-side search filtering for TransactionNo
                    if (!string.IsNullOrWhiteSpace(searchQuery) && ViewModel.ItemDetail != null && ViewModel.ItemDetail.Any())
                    {
                        searchQuery = searchQuery.Trim().Length > 30 ? searchQuery.Trim().Substring(0, 30) : searchQuery.Trim();
                        var lowerSearchQuery = searchQuery.ToLower();
                        
                        // Check if search query is a barcode (length >= 30)
                        if (searchQuery.Length >= 30)
                        {
                            ViewModel.ItemDetail = ViewModel.ItemDetail.Where(item =>
                                !string.IsNullOrEmpty(item.Barcode) && item.Barcode.ToLower().Contains(lowerSearchQuery)
                            ).ToList();
                        }
                        else
                        {
                            // Search across multiple fields
                            ViewModel.ItemDetail = ViewModel.ItemDetail.Where(item =>
                                item.ItemID.ToLower().Contains(lowerSearchQuery) ||
                                item.NIE_BPOM!.ToLower().Contains(lowerSearchQuery) ||
                                item.BatchID!.ToLower().Contains(lowerSearchQuery) ||
                                item.ItemName!.ToLower().Contains(lowerSearchQuery) ||
                                (item.BinName ?? string.Empty).ToLower().Contains(lowerSearchQuery) ||
                                (item.Barcode ?? string.Empty).ToLower().Contains(lowerSearchQuery)
                            ).ToList();
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(searchQuery) && ViewModel.ItemDetail != null && ViewModel.ItemDetail.Any())
                    {
                        ViewModel.ItemDetail = ViewModel.ItemDetail.OrderBy(a => a.ExpiredDate).Take(100).ToList();
                    }

                    var isProceed = await _context.MultiBatchBalanceBinLogs.AsNoTracking().AnyAsync(a => a.TransactionNo == TransactionNo);
                    if (isProceed)
                    {
                        ViewModel.isTransactionProceed = true;
                    }
                    break;
            }

            var queryBin = await (
                                from mbibin in _context.MultiBatchItemBins.AsNoTracking()
                                where mbibin.LocationID == LocationID
                                orderby mbibin.BinName
                                select new BinViewModel
                                {
                                    BinID = mbibin.BinID,
                                    BinName = mbibin.BinName,
                                }
                                )
                                .ToListAsync();
            ViewModel.ItemBin = queryBin;
            return (ViewModel, LocationID);
        }

        #endregion

        #region CRUD Operation

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(string toolbarData)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with Argument {toolbarData}");
            try
            {
                var parsedData = JsonSerializer.Deserialize<SaveDTO>(toolbarData);
                //var parsedData = JsonSerializer.Deserialize<List<ItemDetailViewModel>>(toolbarData);
                string LocationID = parsedData?.LocationID ?? string.Empty;
                string TransactionNo = parsedData?.TransactionNo ?? string.Empty;
                string? SelectionType = parsedData?.SelectionType;
                string? SearchQuery = parsedData?.SearchQuery;

                if (parsedData == null || parsedData.ItemDetailViewModel == null || parsedData.ItemDetailViewModel.Count == 0)
                {
                    TempData["Error"] = "Error Parsing Data from JSON";
                    //ViewBag.Error = "Error Parsing Data from JSON";
                    //ViewBag.ToolbarData = toolbarData;
                    //onEdit();
                    //var openBatches = await GetOpenBatch(LocationID);
                    //ViewBag.LocationID = LocationID;
                    //var location = await _context.Locations.FirstOrDefaultAsync(a => a.LocationID == LocationID);
                    //ViewBag.LocationName = location?.LocationName;
                    //return View("Index", openBatches);
                    if (SelectionType == "Location" || SelectionType == "TransactionNo")
                    {
                        Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with Error Parsing Data from JSON. Type: {SelectionType}, TransNo: {TransactionNo}, LocID: {LocationID}, Search: {SearchQuery}");
                        return RedirectToAction("Index", new { LocID = LocationID, SelectionType, TransactionNo, md = AppEnum.DataMode.Edit, searchQuery = SearchQuery });
                    }
                    else
                    {
                        Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with Error Parsing Data from JSON");
                        return RedirectToAction("Index");
                    }
                }

                if (SelectionType == "TransactionNo" && !string.IsNullOrWhiteSpace(TransactionNo))
                {
                    LocationID = (await _context.ItemTransactions.FirstOrDefaultAsync(a => a.TransactionNo == TransactionNo))!.ToLocationID!;
                }
                else
                {
                    Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with Type: {SelectionType} and TransNo: {TransactionNo}");
                }

                foreach (var data in parsedData.ItemDetailViewModel!)
                {
                    var datambblcMatch = _context.MultiBatchBalances.AsEnumerable().FirstOrDefault(a => a.LocationID == LocationID
                                                                                        && a.ItemID == data.ItemID
                                                                                        && a.NIE_BPOM == data.NIE_BPOM
                                                                                        && a.BatchID == data.BatchID
                                                                                        && a.ExpiredDate.Date == Convert.ToDateTime(data.ExpiredDate).Date
                                                                                        );
                    if (datambblcMatch != null)
                    {
                        datambblcMatch.isOpen = true;
                    }

                    if (!data.BinID.HasValue)
                    {
                        continue;
                    }

                    DateTime.TryParse(data.ExpiredDate, out DateTime ED);
                    var datambblcbinMatch = await _context.MultiBatchBalanceBins.FirstOrDefaultAsync(a => a.LocationID == LocationID
                                                                                    && a.BinID == data.BinID
                                                                                    && a.ItemID == data.ItemID
                                                                                    && a.NIE_BPOM == data.NIE_BPOM
                                                                                    && a.BatchID == data.BatchID
                                                                                    && a.ExpiredDate == ED
                                                                               );
                    var logTransactionNo = SelectionType == "TransactionNo" ? TransactionNo : "OpenBatch";
                    var qtymax = datambblcMatch?.Balance ?? 0;

                    if (datambblcbinMatch != null)
                    {
                        var qtycurrent = datambblcbinMatch.Quantity;
                        var qtyprocess = qtycurrent + data.BinQty;
                        var qty = qtymax < qtyprocess ? (qtymax - qtycurrent) : data.BinQty;

                        if(qty < 0)
                        {
                            Log.Warning($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with Negative Quantity Calculation for ItemID {data.ItemID}, NIE_BPOM {data.NIE_BPOM}, BatchID {data.BatchID}, ExpiredDate {data.ExpiredDate} in Location {LocationID} with max {qtymax} nad current {qtycurrent}");
                            qty = 0;
                        }

                        datambblcbinMatch.Quantity += qty;
                        datambblcbinMatch.LastUpdateUser = _UserID;
                        datambblcbinMatch.LastUpdateDate = DateTime.Now;


                        MultiBatchBalanceBinLog newlog = new MultiBatchBalanceBinLog
                        {
                            MultiBatchBalanceBinID = datambblcbinMatch.MultiBatchBalanceBinID,
                            QtyIn = qty,
                            QtyOut = 0,
                            CreatedBy = _UserID,
                            CreatedDate = DateTime.Now,
                            TransactionNo = logTransactionNo
                        };
                        _context.MultiBatchBalanceBinLogs.Add(newlog);
                    }
                    else
                    {
                        if(data.BinQty <= qtymax)
                        {
                            var newBin = new MultiBatchBalanceBin
                            {
                                LocationID = LocationID,
                                BinID = data.BinID.Value,
                                ItemID = data.ItemID,
                                NIE_BPOM = data.NIE_BPOM!,
                                BatchID = data.BatchID!,
                                ExpiredDate = ED,
                                Quantity = data.BinQty,
                                LastUpdateUser = _UserID,
                                LastUpdateDate = DateTime.Now,
                                Barcode = data.Barcode,
                                MultiBatchBalanceBinLogs = new List<MultiBatchBalanceBinLog>
                                {
                                    new MultiBatchBalanceBinLog
                                    {
                                        QtyIn = data.BinQty,
                                        QtyOut = 0,
                                        CreatedBy = _UserID,
                                        CreatedDate = DateTime.Now,
                                        TransactionNo = logTransactionNo
                                    }
                                }
                            };
                            _context.MultiBatchBalanceBins.Add(newBin);
                        }
                        else
                        {
                            Log.Error($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with Bin Quantity {data.BinQty} exceed Balance Quantity {qtymax} for ItemID {data.ItemID}, NIE_BPOM {data.NIE_BPOM}, BatchID {data.BatchID}, ExpiredDate {data.ExpiredDate} in Location {LocationID}");
                        }
                    }
                }
                _context.SaveChanges();

                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} and Redirect To {nameof(Index)} with Location {LocationID} and Search for {SearchQuery}");
                return RedirectToAction("Index", new { LocID = LocationID, SelectionType, TransactionNo, md = AppEnum.DataMode.View, searchQuery = SearchQuery });
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"{_UserID} Accessing {_ControllerName} on method {nameof(Save)} with Argument {toolbarData}");
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cancel(string toolbarData)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Cancel)} with Argument {toolbarData}");
            try
            {
                if (string.IsNullOrWhiteSpace(toolbarData))
                {
                    Log.Warning($"{_UserID} {nameof(Cancel)} called with null or empty toolbarData");
                    return RedirectToAction("Index");
                }

                var parsedData = JsonSerializer.Deserialize<EditCancelDTO>(toolbarData);

                if (parsedData == null)
                {
                    return RedirectToAction("Index");
                }


                string? locationID = parsedData.LocationID;
                string selectionType = parsedData.SelectionType!;
                string? transactionNo = parsedData.TransactionNo;

                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Cancel)} and Redirect To {nameof(Index)} with SelectionType: {selectionType}, Location: {locationID}, TransactionNo: {transactionNo}");

                return RedirectToAction("Index", new
                {
                    LocID = locationID,
                    SelectionType = selectionType,
                    TransactionNo = transactionNo,
                    md = AppEnum.DataMode.View,
                    searchQuery = parsedData.SearchQuery
                });
            }

            catch (JsonException ex)
            {
                Log.Error(ex, $"{_UserID} Error parsing JSON in {nameof(Cancel)}");
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string toolbarData)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Edit)} with Argument {toolbarData}");
            try
            {
                if (string.IsNullOrWhiteSpace(toolbarData))
                {
                    Log.Warning($"{_UserID} {nameof(Edit)} called with null or empty toolbarData");
                    return RedirectToAction("Index");
                }

                var parsedData = JsonSerializer.Deserialize<EditCancelDTO>(toolbarData);

                if (parsedData == null)
                {
                    return RedirectToAction("Index");
                }


                string? locationID = parsedData.LocationID;
                string selectionType = parsedData.SelectionType!;
                string? transactionNo = parsedData.TransactionNo;

                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Edit)} and Redirect To {nameof(Index)} with SelectionType: {selectionType}, Location: {locationID}, TransactionNo: {transactionNo}");

                return RedirectToAction("Index", new
                {
                    LocID = locationID,
                    SelectionType = selectionType,
                    TransactionNo = transactionNo,
                    md = AppEnum.DataMode.Edit,
                    searchQuery = parsedData.SearchQuery
                });
            }

            catch (JsonException ex)
            {
                Log.Error(ex, $"{_UserID} Error parsing JSON in {nameof(Edit)}");
                return RedirectToAction("Index");
            }
        }

        #endregion

        #region DTO

        private class EditCancelDTO
        {
            public string? SelectionType { get; set; }
            public string? LocationID { get; set; }
            public string? TransactionNo { get; set; }
            public string? SearchQuery { get; set; }
        }
        private class SaveDTO
        {
            public List<ItemDetailViewModel>? ItemDetailViewModel { get; set; }
            public string? SelectionType { get; set; }
            public string? LocationID { get; set; }
            public string? TransactionNo { get; set; }
            public string? SearchQuery { get; set; }

        }
        #endregion
    }
}