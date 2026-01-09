using AspNetCoreGeneratedDocument;
using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using AvicennaDispensing.Models;
using AvicennaDispensing.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.RateLimiting;
using System.Xml.Serialization;
using static AvicennaDispensing.ViewModels.BinOpnameViewModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AvicennaDispensing.Controllers
{
    public class BinOpnameController : BaseController
    {
        public BinOpnameController(ApplicationDbContext context) : base (context)
        {

        }
        public async Task<IActionResult> Index(string? context, string? TransactionNo, DateTime? StartDate, DateTime? EndDate)
        {
            List<BinOpnameList> viewmodel; List<queryListDTO> TransactionNoList = new(); List<queryListDTO> query = new();

            switch (context) 
            {
                case "Search":
                    if (!string.IsNullOrWhiteSpace(TransactionNo))
                    {
                        TransactionNoList = await _context.ItemTransactions.Where(it => it.TransactionCode == ((int)AppEnum.TransactionCode.StockOpname).ToString("D3")
                                                                            && it.TransactionNo.ToLower().Contains(TransactionNo.ToLower()))
                                            .Select(a => new queryListDTO
                                            {
                                                TransactionNo = a.TransactionNo,
                                                TransactionDate = a.TransactionDate,
                                            }).OrderByDescending(a => a.TransactionNo).ToListAsync();
                    }
                    else
                    {
                        TransactionNoList = await _context.ItemTransactions.Where(it => it.TransactionCode == ((int)AppEnum.TransactionCode.StockOpname).ToString("D3"))
                                                                    .Select(a => new queryListDTO
                                                                    {
                                                                        TransactionNo = a.TransactionNo,
                                                                        TransactionDate = a.TransactionDate,
                                                                    }).OrderByDescending(a => a.TransactionNo).Take(100).ToListAsync();
                    }
                    break;
                case "DateFilter":
                    if (StartDate.HasValue && EndDate.HasValue)
                    {
                        TransactionNoList = await _context.ItemTransactions.Where(it => it.TransactionCode == ((int)AppEnum.TransactionCode.StockOpname).ToString("D3")
                                                                                    && StartDate <= it.TransactionDate && it.TransactionDate <= EndDate)
                                                                     .Select(a => new queryListDTO
                                                                     {
                                                                         TransactionNo = a.TransactionNo,
                                                                         TransactionDate = a.TransactionDate,
                                                                     }).OrderByDescending(a => a.TransactionNo).ToListAsync();
                    }
                    else if (StartDate.HasValue && !EndDate.HasValue)
                    {
                        TransactionNoList = await _context.ItemTransactions.Where(it => it.TransactionCode == ((int)AppEnum.TransactionCode.StockOpname).ToString("D3")
                                                                                        && StartDate <= it.TransactionDate)
                                                                         .Select(a => new queryListDTO
                                                                         {
                                                                             TransactionNo = a.TransactionNo,
                                                                             TransactionDate = a.TransactionDate,
                                                                         }).OrderByDescending(a => a.TransactionNo).ToListAsync();
                    }
                    else
                    {
                        TransactionNoList = await _context.ItemTransactions.Where(it => it.TransactionCode == ((int)AppEnum.TransactionCode.StockOpname).ToString("D3")
                                                                                    && it.TransactionDate <= (EndDate ?? DateTime.Now))
                                                                     .Select(a => new queryListDTO
                                                                     {
                                                                         TransactionNo = a.TransactionNo,
                                                                         TransactionDate = a.TransactionDate,
                                                                     }).OrderByDescending(a => a.TransactionNo).Take(100).ToListAsync();
                    }
                    break;
                default:
                    TransactionNoList = await _context.ItemTransactions.Where(it => it.TransactionCode == ((int)AppEnum.TransactionCode.StockOpname).ToString("D3"))
                                                         .Select(a => new queryListDTO
                                                         {
                                                             TransactionNo = a.TransactionNo,
                                                             TransactionDate = a.TransactionDate,
                                                         }).OrderByDescending(a => a.TransactionNo).Take(100).ToListAsync();
                    break;
            }

            query = (from it in TransactionNoList
                     join isoa in _context.ItemStockOpnameApprovals on it.TransactionNo equals isoa.TransactionNo
                     select new queryListDTO
                     {
                         TransactionNo = it.TransactionNo,
                         TransactionDate = it.TransactionDate,
                         Page = isoa.PageNo,
                         isApproved = isoa.IsApproved
                     }
                     ).ToList();

            viewmodel = query.GroupBy(a => new { a.TransactionNo, a.TransactionDate })
                                .Select(a => new BinOpnameList
                                {
                                    TransactionNo = a.Key.TransactionNo,
                                    TransactionDate = a.Key.TransactionDate,
                                    FilterList = a.Select(x => new FilterListStatus
                                    {
                                        FilterName = x.Page.ToString(),
                                        isApproved = x.isApproved
                                    }).OrderBy(a => a.FilterName).ToList()
                                }).OrderByDescending(k => k.TransactionNo).ToList();

            ViewBag.Search = TransactionNo;
            ViewBag.StartDate = StartDate?.ToString("yyyy-MM-dd");
            ViewBag.EndDate = EndDate?.ToString("yyyy-MM-dd");

            return View(viewmodel);
        }
        public async Task<IActionResult> DetailTransaction(string TransactionNo, string? filterOption, string? DataMode)
        {
            PageDetail viewmodel = await FilterList(TransactionNo, filterOption);
            if (!string.IsNullOrWhiteSpace(filterOption)) onView();
            return View("DetailTransaction", viewmodel);
        }
        public async Task<IActionResult> TransactionPageDetail(string TransactionNo, string SortID, string? SortSelection, string DataMode)
        {
            var viewmodel = await FilterDetail(TransactionNo, SortSelection, SortID, DataMode);
            return PartialView("_PageDetail", viewmodel);
        }
        public async Task<IActionResult> BinList(string TransactionNo)
        {
            //var viewmodel = await FilterDetail(TransactionNo, SortSelection, SortID);
            var query = await _context.ItemTransactions.FirstOrDefaultAsync(a => a.TransactionNo == TransactionNo);
            string LocationID = query?.FromLocationID ?? string.Empty;
            var BinList = await _context.MultiBatchItemBins.Where(a => a.LocationID == LocationID).ToListAsync();
            return Json(new { success = true, data = BinList });
        }

        #region CRUD
        public async Task<IActionResult> Edit(string toolbarData)
        {
            string[] data = toolbarData.Split('|');
            string TransactionNo = data[0];
            string filterOption = data[1];
            string? SortID = string.IsNullOrWhiteSpace(data[2]) ? null : data[2];
            PageDetail viewmodel = await FilterList(TransactionNo, filterOption, SortID);
            onEdit();
            return View("DetailTransaction", viewmodel);
        }
        public async Task<IActionResult> Cancel(string toolbarData)
        {
            string[] data = toolbarData.Split('|');
            string TransactionNo = data[0];
            string filterOption = data[1];
            string? SortID = string.IsNullOrWhiteSpace(data[2]) ? null : data[2];
            PageDetail viewmodel = await FilterList(TransactionNo, filterOption, SortID);
            onSaveCancel();
            return View("DetailTransaction", viewmodel);
        }
        public async Task<IActionResult> Save(string TransactionNo, string filterOption, string toolbarData)
        {
            PageDetail viewmodel = await FilterList(TransactionNo, filterOption);
            onSaveCancel();

            var data = JsonSerializer.Deserialize<SaveDataDTO>(toolbarData)!;
            var LocationID = (await _context.ItemTransactions.FirstOrDefaultAsync(a => a.TransactionNo == TransactionNo))!.FromLocationID;

            //MB
            var MBDatasExist = _context.MultiBatches.Where(a => a.TransactionNo == TransactionNo);
            var MBTempDatasExist = _context.MultiBatchTemps.Where(a => a.TransactionNo == TransactionNo);

            foreach (var row in data.Datas!)
            {
                int BinID = -1;
                if (string.IsNullOrEmpty(row.binName))
                {
                    BinID = (await _context.MultiBatchItemBins.FirstOrDefaultAsync(a => a.LocationID == LocationID && a.BinName == row.binName))!.BinID;
                }
                DateTime.TryParse(row.expiredDate, out DateTime ExpiredDate);
                decimal.TryParse(row.totalQty, out decimal Qty);
                decimal.TryParse(row.binQty, out decimal binQty);

                //MB
                if(!string.IsNullOrWhiteSpace(row.itemId) && !string.IsNullOrWhiteSpace(row.nieBpom) && !string.IsNullOrWhiteSpace(row.batch) && !string.IsNullOrWhiteSpace(row.expiredDate.ToString()))
                {
                    var MBData = await MBDatasExist.FirstOrDefaultAsync(a => a.ItemID == row.itemId && a.BatchID == row.batch && a.NIE_BPOM == row.nieBpom && a.ExpiredDate == ExpiredDate);
                    var MBTempData = await MBTempDatasExist.FirstOrDefaultAsync(a => a.ItemID == row.itemId && a.BatchID == row.batch && a.NIE_BPOM == row.nieBpom && a.ExpiredDate == ExpiredDate && a.BinID == BinID);
                    if (MBData != null)
                    {
                        MBData.Quantity = Qty;
                        MBData.LastUpdatebyID = _UserID;
                        MBData.LastUpdatebyTime = DateTime.Now;
                    }
                    else
                    {
                        var ItemObject = (await _context.ItemTransactionItems.FirstOrDefaultAsync(a => a.TransactionNo == TransactionNo && a.ItemID == row.itemId))!;
                        var newMB = new MultiBatch
                        {
                            TransactionNo = TransactionNo,
                            SequenceNo = ItemObject.SequenceNo,
                            ReferenceNo = ItemObject.ReferenceNo,
                            ReferenceSequenceNo = ItemObject.ReferenceSequenceNo,
                            ItemID = row.itemId,
                            NIE_BPOM = row.nieBpom,
                            BatchID = row.batch,
                            ExpiredDate = Convert.ToDateTime(row.expiredDate),
                            Quantity = Qty,
                            SRItemUnit = ItemObject.SRItemUnit,
                            LastUpdatebyID = _UserID,
                            LastUpdatebyTime = DateTime.Now,
                            Status = "PENDING",
                            StatusByUserID = _UserID,
                            StatusByDateTime = DateTime.Now
                        };
                        _context.MultiBatches.Add(newMB);
                    }
                    if(MBTempData != null)
                    {
                        MBTempData.Quantity = binQty;
                        MBTempData.LastUpdateDateTime = DateTime.Now;
                        MBTempData.LastUpdateByUserID = _UserID;
                    }
                    else if(MBTempData == null && !string.IsNullOrWhiteSpace(row.binName))
                    {
                        var NewMBTemp = new MultiBatchTemp
                        {
                            TransactionNo = TransactionNo,
                            ItemID = row.itemId,
                            NIE_BPOM = row.nieBpom,
                            BatchID = row.batch,
                            ExpiredDate = Convert.ToDateTime(row.expiredDate),
                            Quantity = binQty,
                            BinID = BinID,
                            LastUpdateByUserID = _UserID,
                            LastUpdateDateTime = DateTime.Now
                        };
                    }
                }

                //await _context.SaveChangesAsync();
            }
            return View("DetailTransaction", viewmodel);
        }
        #endregion

        public async Task<PageDetail> FilterList(string TransactionNo, string? FilterOption, string? FilterID = null)
        {
            PageDetail viewmodel;

            if (FilterOption == "item")
            {
                PageDetail? DetailList = null;
                var PageList = await _context.ItemStockOpnameApprovals.Where(a => a.TransactionNo == TransactionNo).ToListAsync();
                if(!string.IsNullOrWhiteSpace(FilterID))
                {
                    DetailList = await FilterDetail(TransactionNo, FilterOption, FilterID!);
                }
                viewmodel = new PageDetail
                {
                    TransactionNo = TransactionNo,
                    SortType = FilterOption,
                    SortID = FilterID,
                    FilterList = PageList.Select(a => new FilterListStatus
                    {
                        FilterName = a.PageNo.ToString(),
                        isApproved = a.IsApproved
                    }).OrderBy(a => a.FilterName).ToList(),
                    DetailList = DetailList?.DetailList  
                };
            }
            else if (FilterOption == "bin")
            {
                var LocationID = User.FindFirst(ClaimTypesCustom.Service_Unit)?.Value;
                var BinList = await _context.MultiBatchItemBins.Where(a => a.LocationID == LocationID).ToListAsync();
                viewmodel = new PageDetail
                {
                    TransactionNo = TransactionNo,
                    SortType = FilterOption,
                    FilterList = BinList.Select(a => new FilterListStatus
                    {
                        FilterName = a.BinName
                    }).OrderBy(a => a.FilterName).ToList()
                };
            }
            else
            {
                viewmodel = new PageDetail
                {
                    TransactionNo = TransactionNo
                };
            }
            return viewmodel;
        } 
        public async Task<PageDetail> FilterDetail(string TransactionNo, string? SortSelection, string SortID, string? DataMode = null)
        {
            PageDetail viewmodel = new(); List<PageDetail.FilterDetail> DetailList = new();
            string LocationID = (await _context.ItemTransactions.FirstOrDefaultAsync(a => a.TransactionNo == TransactionNo))!.FromLocationID!;

            var sciData = await (from iti in _context.ItemTransactionItems
                                 join i in _context.Items on iti.ItemID equals i.ItemID
                                 join ipm in _context.ItemProductMedics on iti.ItemID equals ipm.ItemID
                                 where iti.TransactionNo == TransactionNo && iti.PageNo.ToString() == SortID
                                 select new
                                 {
                                     iti.ItemID,
                                     i.ItemName,
                                     iti.Quantity,
                                     ipm.IsControlExpired
                                 })
                     .ToListAsync();

            if (SortSelection == "item")
            {
                //MB balance
                foreach (var row in sciData)
                {
                    var detailblcdata = await _context.MultiBatchBalances.Where(a => a.LocationID == LocationID
                                                                                    && a.ItemID == row.ItemID
                                                                                    )
                                                                            .ToListAsync();
                    if (detailblcdata != null && detailblcdata.Count > 0)
                    {
                        // MB BalanceBins
                        foreach (var item in detailblcdata)
                        {
                            var detailblcbindata = await _context.MultiBatchBalanceBins.Where(a => a.LocationID == LocationID
                                                                                                && a.ItemID == item.ItemID
                                                                                                && a.NIE_BPOM == item.NIE_BPOM
                                                                                                && a.BatchID == item.BatchID
                                                                                                && a.ExpiredDate == item.ExpiredDate)
                                                                                        .ToListAsync();
                            if (detailblcbindata != null && detailblcbindata.Count > 0)
                            {
                                foreach (var bindata in detailblcbindata)
                                {
                                    var BinName = _context.MultiBatchItemBins.FirstOrDefault(a => a.BinID == bindata.BinID && a.LocationID == LocationID)!.BinName;
                                    DetailList.Add(new PageDetail.FilterDetail
                                    {
                                        ItemID = row.ItemID,
                                        ItemName = row.ItemName,
                                        NIE_BPOM = item.NIE_BPOM,
                                        BatchID = item.BatchID,
                                        ExpiredDate = item.ExpiredDate,
                                        TotalQuantity = item.Balance,
                                        isOpen = item.isOpen,
                                        BinID = bindata.BinID,
                                        BinName = BinName,
                                        BinQty = bindata.Quantity,
                                        isControlExpired = row.IsControlExpired
                                    });
                                }
                            }
                            else
                            {
                                DetailList.Add(new PageDetail.FilterDetail
                                {
                                    ItemID = row.ItemID,
                                    ItemName = row.ItemName,
                                    NIE_BPOM = item.NIE_BPOM,
                                    BatchID = item.BatchID,
                                    ExpiredDate = item.ExpiredDate,
                                    TotalQuantity = item.Balance,
                                    isOpen = item.isOpen,
                                    isControlExpired = row.IsControlExpired
                                });
                            }
                        }
                    }
                    else
                    {
                        DetailList.Add(new PageDetail.FilterDetail
                        {
                            ItemID = row.ItemID,
                            ItemName = row.ItemName,
                            TotalQuantity = row.Quantity,
                            isControlExpired = row.IsControlExpired
                        });
                    }
                    viewmodel = new PageDetail
                    {
                        SortID = SortID,
                        DataMode = DataMode,
                        SortType = SortSelection ?? string.Empty,
                        DetailList = DetailList
                    };
                }
            }

            else
            {
                foreach (var data in sciData)
                {
                    var query = await (from mbblcb in _context.MultiBatchBalanceBins
                                       join mbib in _context.MultiBatchItemBins on mbblcb.BinID equals mbib.BinID
                                       where mbblcb.LocationID == LocationID && mbblcb.ItemID == data.ItemID
                                       select new
                                       {
                                           mbblcb,
                                           mbib.BinName
                                       }
                                      ).ToListAsync();

                    foreach (var row in query)
                    {
                        DetailList.Add(new PageDetail.FilterDetail
                        {
                            ItemID = data.ItemID,
                            ItemName = data.ItemName,
                            NIE_BPOM = row.mbblcb.NIE_BPOM,
                            BatchID = row.mbblcb.BatchID,
                            ExpiredDate = row.mbblcb.ExpiredDate,
                            BinID = row.mbblcb.BinID,
                            BinQty = row.mbblcb.Quantity,
                            BinName = row.BinName
                        });
                    }
                }
                viewmodel = new PageDetail
                {
                    SortID = SortID,
                    SortType = SortSelection ?? string.Empty,
                    DetailList = DetailList
                };
            }
            return viewmodel;
        }
        private class queryListDTO
        {
            public string TransactionNo { get; set; } = null!;
            public DateTime TransactionDate { get; set; }
            public int Page { get; set; }
            public bool? isApproved { get; set; }
        }
        private class SaveDataDTO
        {
            public string TransactionNo { get; set; } = null!;
            public List<DataDTO>? Datas { get; set; }
            public class DataDTO
            {
                public string itemId { get; set; } = null!;
                public string totalQty { get; set; } = null!;
                public string nieBpom { get; set; } = null!;
                public string batch { get; set; } = null!;
                public string expiredDate { get; set; } = null!;
                public string binName { get; set; } = null!;
                public string binQty { get; set; } = null!;
            }
        }
    }
}
