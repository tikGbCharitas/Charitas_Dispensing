using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using AvicennaDispensing.Models;
using Azure;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static AvicennaDispensing.ViewModels.DispensingViewModel;
using static AvicennaDispensing.ViewModels.DispensingViewModel.DispensingBinViewModel;
using static AvicennaDispensing.ViewModels.DispensingViewModel.DispensingDetailViewModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AvicennaDispensing.Controllers
{
    public class DispensingController : BaseController
    {
        public DispensingController(ApplicationDbContext context) : base(context)
        {

        }

        #region General
        public IActionResult Index()
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)}");
            var locationClaim = User.FindFirst(ClaimTypesCustom.Service_Unit)?.Value;
            if (string.IsNullOrWhiteSpace(locationClaim))
            {
                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)} with no Location");
                return View();
            }

            var locationIds = locationClaim
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Select(id => id.Trim())
                .ToList();

            var locations = _context.Locations.AsEnumerable()
                .Where(loc => locationIds.Contains(loc.LocationID))
                .ToList();
            ViewData["Locations"] = locations;
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)} success");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckScannedData([FromBody] JsonElement payload)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(CheckScannedData)} with Argument {payload}");
            try
            {
                DispensingListViewModel Datas = new DispensingListViewModel();
                string? PrescriptionNo = payload.GetProperty("PrescriptionNo").GetString()?.Trim();
                if (!string.IsNullOrWhiteSpace(PrescriptionNo))
                {
                    Datas = await CheckPrescriptionNo(PrescriptionNo);
                }

                List<DispensingListViewModel> TransactionList = new List<DispensingListViewModel>();
                var JsonTransactionList = payload.GetProperty("Details").EnumerateArray();
                TransactionList.Add(Datas);
                foreach (var item in JsonTransactionList)
                {
                    if (!string.IsNullOrWhiteSpace(PrescriptionNo) && PrescriptionNo == item.GetProperty("PrescriptionNo").GetString())
                    {
                        continue;
                    }
                    else
                    {
                        bool.TryParse(item.GetProperty("Approved").GetString(), out bool isApproved);
                        TransactionList.Add(new DispensingListViewModel
                        {
                            PrescriptionNo = item.GetProperty("PrescriptionNo").GetString() ?? string.Empty,
                            Patient = item.GetProperty("Patient").GetString() ?? string.Empty,
                            RegistrationNo = item.GetProperty("RegistrationNo").GetString() ?? string.Empty,
                            Age = item.GetProperty("Age").GetString() ?? string.Empty,
                            MedicalNo = item.GetProperty("MedicalNo").GetString() ?? string.Empty,
                            Sex = item.GetProperty("Sex").GetString() ?? string.Empty,
                            Height = item.GetProperty("Height").GetString() ?? string.Empty,
                            Weight = item.GetProperty("Weight").GetString() ?? string.Empty,
                            Approved = isApproved,
                            DeliverDateTime = item.GetProperty("Delivered").GetString()
                        });
                    }
                }
                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(CheckScannedData)} with return data {JsonSerializer.Serialize(TransactionList)}");
                return PartialView("_ScannedList", TransactionList);
            }
            catch (Exception ex)
            {
                Log.Error($"🔥 ERROR for {_UserID} Accessing {_ControllerName} on method {nameof(CheckScannedData)}: {ex}");
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetailTransaction([FromBody] JsonElement payload)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(DetailTransaction)} with Argument {payload}");

            string PrescriptionNo = payload.GetProperty("PrescriptionNo").GetString()!.Trim();
            string? PatientName = payload.GetProperty("PatientName").GetString()?.Trim();
            string? RegistrationNo = payload.GetProperty("RegistrationNo").GetString()?.Trim();
            string? MedicalNo = payload.GetProperty("MedicalNo").GetString()?.Trim();
            string? Age = payload.GetProperty("Age").GetString()?.Trim();
            string? Sex = payload.GetProperty("Sex").GetString()?.Trim();
            string? Weight = payload.GetProperty("Weight").GetString()?.Trim();
            string? Height = payload.GetProperty("Height").GetString()?.Trim();
            string? LocationID = payload.GetProperty("LocationID").GetString()?.Trim();
            string? Approval = payload.GetProperty("Approval").GetString()?.Trim();
            string? Delivered = payload.GetProperty("Delivered").GetString()?.Trim();

            bool.TryParse(Approval, out bool isApproved);

            DispensingDetailViewModel Datas = new DispensingDetailViewModel
            {
                PrescriptionNo = PrescriptionNo,
                RegistrationNo = RegistrationNo,
                Patient = PatientName,
                Age = Age,
                MedicalNo = MedicalNo,
                Sex = Sex,
                Height = Height,
                Weight = Weight,
                Approved = isApproved,
                DeliverDateTime = Delivered,
            };

            if (!isApproved)
            {
                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(DetailTransaction)} with {PrescriptionNo} is not apprroved yet");
                return PartialView("_ScannedDetail", Datas);
            }
            else if (!string.IsNullOrWhiteSpace(Delivered))
            {
                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(DetailTransaction)} with {PrescriptionNo} has been delivered");
                return PartialView("_ScannedDetail", Datas);
            }

            List<DispensingItemGroupViewModel>? ItemGroupViewModel = null;

            ItemGroupViewModel = await GetDetailTransaction(PrescriptionNo, LocationID);

            Datas.ItemGroupsDatas = ItemGroupViewModel;
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(DetailTransaction)} with return data {JsonSerializer.Serialize(Datas)}");
            return PartialView("_ScannedDetail", Datas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetBinList([FromBody] JsonElement request)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetBinList)} with Argument {request}");
            DispensingBinViewModel Datas = await GetAvaibleBinAndBinBalance(request.GetProperty("PrescriptionNo").GetString()!.Trim(), request.GetProperty("LocationID").GetString()!.Trim(), request.GetProperty("ItemID").GetString()!.Trim());
            Datas.PrescriptionNo = request.GetProperty("PrescriptionNo").GetString()!.Trim();
            Datas.ItemName = request.GetProperty("ItemName").GetString()?.Trim() ?? string.Empty;
            Datas.FrontEndData = request.GetProperty("EDBatchList");
            Datas.FrontEndTotalQty = Datas.FrontEndData.EnumerateArray().Sum(a => decimal.TryParse(a.GetProperty("Qty").GetString(), CultureInfo.InvariantCulture, out var val) ? val : 0);
            string html = await this.RenderPartialViewToStringAsync("_ChangeBalanceDetail", Datas);
            //return PartialView("_ChangeBalanceDetail", Datas);
            var response = new
            {
                Datas.BinList,
                html
            };
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetBinList)} with return data {JsonSerializer.Serialize(response.BinList)}");
            return Json(response);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveChanged([FromBody] JsonElement request)
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(SaveChanged)} with Argument {request}");
            try
            {
                string ItemID = request.GetProperty("ItemID").GetString()!.Trim();
                string LocationID = request.GetProperty("LocationID").GetString()!.Trim();
                string PrescriptionNo = request.GetProperty("PrescriptionNo").GetString()!.Trim();

                string? ServiceUnit = (await _context.AppUsers.FirstOrDefaultAsync(a => a.UserID == _UserID.Trim()))?.ServiceUnitID;

                var existingmb = await _context.MultiBatches.FirstOrDefaultAsync(a => a.TransactionNo == PrescriptionNo && a.ItemID == ItemID);
                string? SeqNo = existingmb!.SequenceNo;
                string? RefNo = existingmb.ReferenceNo;
                string? RefSeqNo = existingmb.ReferenceSequenceNo;
                string? SRItemUnit = existingmb.SRItemUnit;

                var existingmbmove = await _context.MultiBatchItemMovements.FirstOrDefaultAsync(a => a.TransactionNo == PrescriptionNo && a.ItemID == ItemID);
                Guid? MovementID = existingmbmove!.MovementID;

                var MBBBData = _context.MultiBatchBalanceBins.Where(a => a.LocationID == LocationID && a.ItemID == ItemID);
                var MBBData = _context.MultiBatchBalances.Where(a => a.LocationID == LocationID && a.ItemID == ItemID);

                var Rejected = new List<object>();

                foreach (var data in request.GetProperty("Datas").EnumerateArray())
                {
                    bool isDB = false;

                    if (data.TryGetProperty("isDB", out var prop))
                    {
                        if (prop.ValueKind == JsonValueKind.True) isDB = true;
                        else if (prop.ValueKind == JsonValueKind.False) isDB = false;
                        else if (
                            prop.ValueKind == JsonValueKind.String &&
                            bool.TryParse(prop.GetString(), out var parsed)
                        )
                            isDB = parsed;
                    }

                    var expiredDateStr = data.GetProperty("ExpiredDate").GetString()?.Trim();

                    DateTime parsedDate; DateTime? expiredDate = null;

                    if (DateTime.TryParseExact(expiredDateStr, "MM/dd/yyyy",
                                               CultureInfo.InvariantCulture,
                                               DateTimeStyles.None, out parsedDate))
                    {
                        expiredDate = parsedDate.Date;
                    }

                    string jsonBinID = data.GetProperty("BinID").GetString()!.Trim();
                    int.TryParse(jsonBinID, out int BinID);
                    string NIE_BPOM = data.GetProperty("NIE_BPOM").GetString()!.Trim();
                    string BatchID = data.GetProperty("Batch").GetString()!.Trim();

                    var MBBBMatch = await MBBBData.FirstOrDefaultAsync(a => a.BinID == BinID && a.NIE_BPOM == NIE_BPOM &&
                                                                        a.BatchID == BatchID && expiredDate.HasValue && 
                                                                        a.ExpiredDate.Date == expiredDate.Value
                                                                        );
                    
                    decimal.TryParse(data.GetProperty("Qty").GetString(), CultureInfo.InvariantCulture, out decimal _qty);

                    if(MBBBMatch != null) 
                    {
                        if(MBBBMatch.Quantity >= _qty || isDB)
                        {
                            var MBData = await _context.MultiBatches
                                                        .FirstOrDefaultAsync(a => a.TransactionNo == PrescriptionNo && 
                                                                                a.ItemID == ItemID && a.NIE_BPOM == NIE_BPOM &&
                                                                                a.BatchID == BatchID && expiredDate.HasValue &&
                                                                                a.ExpiredDate!.Value.Date == expiredDate.Value && 
                                                                                a.BinID == BinID);
                            if(MBData != null)
                            {
                                decimal previousQty = (decimal)MBData.Quantity!;
                                decimal delta = _qty - previousQty;

                                //MB
                                MBData.Quantity = _qty;
                                MBData.LastUpdatebyID = _UserID;
                                MBData.LastUpdatebyTime = DateTime.Now;

                                //MB Balance
                                var MBBDataExisting = await MBBData.FirstOrDefaultAsync(a => a.NIE_BPOM == NIE_BPOM && a.BatchID == BatchID && expiredDate.HasValue
                                                                                    && a.ExpiredDate.Date == expiredDate.Value);
                                MBBDataExisting!.LastTransactionNo = PrescriptionNo;
                                MBBDataExisting.LastUpdateByid = _UserID;
                                MBBDataExisting.LastUpdateByTime = DateTime.Now;

                                //MB Movement
                                //var MBIMexist = await _context.MultiBatchItemMovements.FirstOrDefaultAsync(a => a.MultiBatchID == MBData.MultiBatchID);

                                if (delta != 0)
                                {                                    
                                    var NewMBBBLog = new MultiBatchBalanceBinLog();
                                    NewMBBBLog.MultiBatchBalanceBinID = MBBBMatch.MultiBatchBalanceBinID;
                                    NewMBBBLog.TransactionNo = PrescriptionNo;
                                    NewMBBBLog.CreatedBy = _UserID;
                                    NewMBBBLog.CreatedDate = DateTime.Now;

                                    var newMovement = new MultiBatchItemMovement
                                    {
                                        MovementID = MovementID,
                                        MovementDate = DateTime.Now,
                                        ServiceUnitID = ServiceUnit,
                                        LocationID = LocationID,
                                        TransactionNo = PrescriptionNo,
                                        SequenceNo = SeqNo,
                                        ItemID = ItemID,
                                        QuantityIn = 0,
                                        QuantityOut = 0,
                                        LastUpdateByDateTime = DateTime.Now,
                                        LastUpdateByUserID = _UserID,
                                    };

                                    if (delta > 0)
                                    {
                                        //MB Balance Bin Log
                                        NewMBBBLog.QtyIn = 0;
                                        NewMBBBLog.QtyOut = delta;
                                        //MB Balance
                                        MBBDataExisting!.Balance -= delta;
                                        //MB Balance Bin
                                        MBBBMatch.Quantity -= delta;

                                        //MB Movement
                                        newMovement.QuantityOut = delta;
                                    }
                                    else
                                    {
                                        delta = Math.Abs(delta);
                                        //MB Balance Bin Log
                                        NewMBBBLog.QtyIn = delta;
                                        NewMBBBLog.QtyOut = 0;
                                        //MB Balance
                                        MBBDataExisting!.Balance += delta;
                                        MBBDataExisting.isOpen = false;
                                        //MB Balance Bin
                                        MBBBMatch.Quantity += delta;

                                        //MB Movement
                                        newMovement.QuantityIn = delta;
                                    }
                                    _context.MultiBatchBalanceBinLogs.Add(NewMBBBLog);
                                    //_context.MultiBatchItemMovements.Add(newMovement);
                                    if (MBData.MultiBatchItemMovements == null)
                                        MBData.MultiBatchItemMovements = new List<MultiBatchItemMovement>();

                                    MBData.MultiBatchItemMovements.Add(newMovement);
                                }
                            }
                            else
                            {
                                //MB
                                MultiBatch newMBData = new MultiBatch()
                                {
                                    TransactionNo = PrescriptionNo,
                                    SequenceNo = SeqNo,
                                    ReferenceNo = RefNo,
                                    ReferenceSequenceNo = RefSeqNo,
                                    ItemID = ItemID,
                                    NIE_BPOM = NIE_BPOM,
                                    BatchID = BatchID,
                                    ExpiredDate = expiredDate!.Value,
                                    Quantity = _qty,
                                    SRItemUnit = SRItemUnit,
                                    LastUpdatebyID = _UserID,
                                    LastUpdatebyTime = DateTime.Now,
                                    Status = AppEnum.Status.APPROVE.ToString(),
                                    StatusByUserID = _UserID,
                                    StatusByDateTime = DateTime.Now,
                                    Barcode = MBBBMatch.Barcode,
                                    BinID = BinID
                                };

                                //MB Movement
                                newMBData.MultiBatchItemMovements = new List<MultiBatchItemMovement>()
                                {
                                    new MultiBatchItemMovement()
                                    {
                                        MovementID = MovementID,
                                        MovementDate = DateTime.Now,
                                        ServiceUnitID = ServiceUnit,
                                        LocationID = LocationID,
                                        TransactionNo = PrescriptionNo,
                                        SequenceNo = SeqNo,
                                        ItemID = ItemID,
                                        QuantityIn = 0,
                                        QuantityOut = _qty,
                                        LastUpdateByDateTime = DateTime.Now,
                                        LastUpdateByUserID = _UserID
                                    }
                                };
                                await _context.MultiBatches.AddAsync(newMBData);

                                //MB Balance
                                var MBBMatch = await MBBData.FirstOrDefaultAsync(a => a.NIE_BPOM == NIE_BPOM && a.BatchID == BatchID && a.ExpiredDate == expiredDate.Value);
                                MBBMatch!.Balance -= _qty;
                                MBBMatch.LastTransactionNo = PrescriptionNo;
                                MBBMatch.LastUpdateByid = _UserID;
                                MBBMatch.LastUpdateByTime = DateTime.Now;

                                //MB Balance Bin
                                MBBBMatch!.Quantity -= _qty;
                                MBBBMatch.LastUpdateUser = _UserID;
                                MBBBMatch.LastUpdateDate = DateTime.Now;

                                //MB Balance Bin Log
                                var newMBBBLog = new MultiBatchBalanceBinLog()
                                {
                                    MultiBatchBalanceBinID = MBBBMatch.MultiBatchBalanceBinID,
                                    QtyIn = 0,
                                    QtyOut = _qty,
                                    TransactionNo = PrescriptionNo,
                                    CreatedBy = _UserID,
                                    CreatedDate = DateTime.Now
                                };

                                await _context.MultiBatchBalanceBinLogs.AddAsync(newMBBBLog);
                            }
                        }
                        else // This shouldn't happen except modal is open too long, slow internet, or Bin Stock is save with new Qty
                        {
                            Rejected.Add(new
                            {
                                BinID,
                                NIE_BPOM,
                                BatchID,
                                ExpiredDate = expiredDateStr,
                                Reason = "Quantity not enough"
                            }
                            );
                        }
                    }
                    else // This shouldn't happen except modal is open too long or Failed compare ExpiredDate
                    {
                        Rejected.Add(new
                        {
                            BinID,
                            NIE_BPOM,
                            BatchID,
                            ExpiredDate = expiredDateStr,
                            Reason = "EDBatch is not found"
                        }
                        );
                    }
                }

                if(Rejected.Count > 0) // This shouldn't happen except modal is open too long, slow internet, or Bin Stock is save with new Qty
                {
                    Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(SaveChanged)} with rejected {JsonSerializer.Serialize(Rejected)}");
                    return Json(new { success = false, message = Rejected });
                }

                await _context.SaveChangesAsync();
                var key = "TransactionList" + _UserID;
                TempData.Keep(key);

                List<DispensingItemBinDetailViewModel> query = new();
                //var newmbbbjoineddatas = _context.MultiBatchBalanceBins.Where(a => a.LocationID == LocationID && a.ItemID == ItemID)
                //                                                    .Join(_context.MultiBatchItemBins, 
                //                                                            mbbb => mbbb.BinID, 
                //                                                            mbib => mbib.BinID, 
                //                                                            (mbbb, mbib) => new { mbbb, mbib.BinName});

                //var newmbdatas = _context.MultiBatches.Where(a => a.TransactionNo == PrescriptionNo && a.ItemID == ItemID && a.Quantity > 0);

                var newmbdatas = await _context.MultiBatches.AsNoTracking().Join(_context.MultiBatchItemBins,
                                                            mb => mb.BinID,
                                                            mbib => mbib.BinID,
                                                            (mb, mbib) => new { mb, mbib.BinName })
                                                            .Where(a => a.mb.TransactionNo == PrescriptionNo && a.mb.ItemID == ItemID && a.mb.Quantity > 0)
                                                            .ToListAsync();


                foreach (var newmbdata in newmbdatas)
                {
                    //var newmbbbdata = await newmbbbjoineddatas.FirstOrDefaultAsync(a => a.mbbb.NIE_BPOM == newmbdata.NIE_BPOM && a.mbbb.BatchID == newmbdata.BatchID && a.mbbb.ExpiredDate == newmbdata.ExpiredDate);
                    query.Add(new DispensingItemBinDetailViewModel
                    {
                        ItemID = ItemID,
                        NIE_BPOM = newmbdata.mb.NIE_BPOM!,
                        Batch = newmbdata.mb.BatchID!,
                        ExpiredDate = newmbdata.mb.ExpiredDate,
                        Quantity = newmbdata.mb.Quantity,
                        BinID = newmbdata.mb.BinID.ToString()!,
                        BinName = newmbdata.BinName,
                    });
                }                

                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(SaveChanged)} with return success and PartialView model {JsonSerializer.Serialize(query)}");
                return Json(new { success = true, html = await this.RenderPartialViewToStringAsync("_NewBalanceDetail", query) });
            }
            catch (Exception ex)
            {
                Log.Error($"❌ ERROR for {_UserID} Accessing {_ControllerName} on method {nameof(SaveChanged)}: {ex.Message}\n{ex.StackTrace}");
                return Json(new { success = false, message = ex.Message });
            }
        }

        #endregion

        #region Methods
        private async Task<DispensingListViewModel> CheckPrescriptionNo(string PrescriptionNo)
        {
            //string[] Weight = ["akktv13", "bbank", "bbyi", "BRTBD", "BY.DO.WGH"
            //                   , "CLPMRI006", "EECP.08", "FPPSHSA017", "FPRT.21", "KSRI6.001"
            //                   , "LSTPICJ026", "NUT.BB", "NUT.BB.SM", "PIC9.001", "QMCU0035"
            //                   , "RJ.N.BBA", "RJGA.53", "GEN.SGN.01" ];

            //string[] Height = ["akktv14", "BY.DO.LEN", "EECP.07", "KSRI6.002", "LSTPICJ025"
            //                    , "NUT.TB", "PIC9.002", "QMCU0034", "RJ.N.TBA", "RJGA.54"
            //                    , "tbank", "GEN.SGN.01"];

            var query = await (from tp in _context.TransPrescriptions
                               join r in _context.Registrations on tp.RegistrationNo equals r.RegistrationNo
                               join p in _context.Patients on r.PatientID equals p.PatientID
                               where tp.PrescriptionNo == PrescriptionNo
                               select new
                               {
                                   tp.PrescriptionNo,
                                   Patient = $"{p.FirstName} {p.MiddleName} {p.LastName}",
                                   r.RegistrationNo,
                                   r.AgeInYear,
                                   p.Sex,
                                   p.MedicalNo,
                                   tp.IsApproval,
                                   tp.DeliverDateTime,
                                   r.SRRegistrationType
                               }
                                ).FirstOrDefaultAsync();

            if (query == null) 
                return new DispensingListViewModel()
                {
                    PrescriptionNo = PrescriptionNo
                };

            string questionFormId = query.SRRegistrationType == "IPR"
                ? "QuestionFormIdForWeightHeightIpr"
                : "QuestionFormIdForWeightHeightOpr";

            // Get all health records in one query
            var HealthQuery = await _context.PatientHealthRecordLines
                .Where(phrl => phrl.RegistrationNo == query.RegistrationNo
                            && phrl.QuestionFormID == questionFormId
                            && (phrl.QuestionID == "QuestionIdForHeight"
                                || phrl.QuestionID == "QuestionIdForWeight"
                                || phrl.QuestionID == "QuestionIdForHeightBaby"
                                || phrl.QuestionID == "QuestionIdForWeightBaby"))
                .OrderByDescending(phrl => phrl.LastUpdateDateTime)
                .Select(phrl => new { phrl.QuestionID, phrl.QuestionAnswerNum })
                .ToListAsync();

            var heightAdult = HealthQuery.FirstOrDefault(v => v.QuestionID == "QuestionIdForHeight")?.QuestionAnswerNum;
            var HeightRecord = (heightAdult.HasValue && heightAdult.Value != 0)
                ? heightAdult
                : HealthQuery.FirstOrDefault(v => v.QuestionID == "QuestionIdForHeightBaby")?.QuestionAnswerNum;

            var weightAdult = HealthQuery.FirstOrDefault(v => v.QuestionID == "QuestionIdForWeight")?.QuestionAnswerNum;
            var WeightRecord = (weightAdult.HasValue && weightAdult.Value != 0)
                ? weightAdult
                : HealthQuery.FirstOrDefault(v => v.QuestionID == "QuestionIdForWeightBaby")?.QuestionAnswerNum;

            //var HealthRecords = await _context.PatientHealthRecordLines
            //                            .Where(a => a.RegistrationNo == query.RegistrationNo && a.QuestionAnswerNum != null && a.QuestionAnswerNum != 0)
            //                            .ToListAsync();
            //var HeightRecord = HealthRecords.Where(h => Height.Contains(h.QuestionID)).Select(h => h.QuestionAnswerNum).FirstOrDefault();
            //var WeightRecord = HealthRecords.Where(w => Weight.Contains(w.QuestionID)).Select(w => w.QuestionAnswerNum).FirstOrDefault();

            return new DispensingListViewModel
            {
                PrescriptionNo = query.PrescriptionNo,
                RegistrationNo = query.RegistrationNo,
                Patient = query.Patient,
                Age = query.AgeInYear.ToString(),
                MedicalNo = query.MedicalNo,
                Sex = query.Sex,
                Height = HeightRecord?.ToString(),
                Weight = WeightRecord?.ToString(),
                Approved = query.IsApproval,
                DeliverDateTime = query.DeliverDateTime?.ToString() ?? string.Empty
            };
        }

        private async Task<List<DispensingItemGroupViewModel>> GetDetailTransaction(string PrescriptionNo, string? LocationID)
        {
            Dictionary<string, decimal> ItemQtyReq = new(); 
            List<DispensingItemBinDetailViewModel> query = new();

            //Load Prescription
            var itemList = await (from tp in _context.TransPrescriptions
                                  join tpi in _context.TransPrescriptionItems on tp.PrescriptionNo equals tpi.PrescriptionNo
                                  join i in _context.Items on tpi.ItemID equals i.ItemID
                                  join ipm in _context.ItemProductMedics on i.ItemID equals ipm.ItemID
                                  where tp.PrescriptionNo == PrescriptionNo && tpi.ResultQty > 0
                                  select new PrescriptionItemDTO
                                  {
                                      IsApproval = tp.IsApproval,
                                      ItemID = string.IsNullOrEmpty(tpi.ItemInterventionID) ? tpi.ItemID : tpi.ItemInterventionID,
                                      ItemName = i.ItemName,
                                      SequenceNo = tpi.SequenceNo,
                                      ReferenceNo = tpi.ReferenceNo,
                                      ReferenceSequenceNo = tpi.ReferenceSequenceNo,
                                      SRItemUnit = tpi.SRItemUnit,
                                      ResultQty = ((int)tpi.ResultQty),
                                      isControlExpired = ipm.IsControlExpired
                                  }
                                  ).ToListAsync();

            //Load DB First
            var MBLoad = await _context.MultiBatches.Where(m => m.TransactionNo == PrescriptionNo && m.Quantity > 0).ToListAsync();

            if (MBLoad != null && MBLoad.Count > 1)
            {
                #region Approach 1
                //var latestlogs = await _context.MultiBatchBalanceBinLogs
                //                        .Where(m => m.TransactionNo == PrescriptionNo)
                //                        .GroupBy(m => new { m.MultiBatchBalanceBinID, m.TransactionNo })
                //                        .Select(g => new
                //                        {
                //                            g.Key.MultiBatchBalanceBinID,
                //                            g.Key.TransactionNo,
                //                            QtyIn = g.Sum(x => x.QtyOut) - g.Sum(x => x.QtyIn)
                //                        })
                //                        .Where(x => x.QtyIn > 0)
                //                        .ToListAsync();

                //var BinLog = await (from mbbblog in latestlogs
                //                    join mbbb in _context.MultiBatchBalanceBins on mbbblog.MultiBatchBalanceBinID equals mbbb.MultiBatchBalanceBinID
                //                    join mbib in _context.MultiBatchItemBins on mbbb.BinID equals mbib.BinID
                //                    select new
                //                    {
                //                        mbbb,
                //                        mbib.BinID,
                //                        mbib.BinName
                //                    }
                //                    )
                //                    .ToListAsync();

                //foreach (var item in itemList)
                //{                   
                //    var MatchedItem = MBLoad.Where(m => m.ItemID == item.ItemID);
                //    var MatchedTotalQty = MatchedItem.Sum(m => m.Quantity) ?? 0;
                //    if (item.ResultQty - MatchedTotalQty > 0) // This if should not be excuted because has been handle by reject prescription
                //    {
                //        ItemQtyReq[item.ItemID] = item.ResultQty - MatchedTotalQty;
                //    }
                //    foreach (var detailitem in MatchedItem)
                //    {
                //        var Bin = BinLog.Where(a => a.mbbb.ItemID == detailitem.ItemID
                //                                        && a.mbbb.NIE_BPOM == detailitem.NIE_BPOM
                //                                        && a.mbbb.BatchID == detailitem.BatchID
                //                                        && a.mbbb.ExpiredDate == detailitem.ExpiredDate
                //                                        ).FirstOrDefault()!;

                //        query.Add(new DispensingItemBinDetailViewModel
                //        {
                //            ItemID = detailitem.ItemID!,
                //            ItemName = item.ItemName,
                //            NIE_BPOM = detailitem.NIE_BPOM!,
                //            Batch = detailitem.BatchID!,
                //            ExpiredDate = detailitem.ExpiredDate,
                //            Quantity = detailitem.Quantity,
                //            BinName = Bin.BinName,
                //            BinID = Bin.BinID.ToString()
                //        });
                //    }
                //}
                #endregion

                #region Approach 2

                foreach(var row in MBLoad)
                {
                    //var binquery = await _context.MultiBatchBalanceBins
                    //                        .Join(_context.MultiBatchBalanceBinLogs,
                    //                                mbbb => mbbb.MultiBatchBalanceBinID,
                    //                                mbbbl => mbbbl.MultiBatchBalanceBinID,
                    //                                (mbbb, mbbbl) => new { mbbb, mbbbl })
                    //                        .Join(_context.MultiBatchItemBins,
                    //                                join => join.mbbb.BinID,
                    //                                mbib => mbib.BinID,
                    //                                (join, mbib) => new { join.mbbb, join.mbbbl, mbib.BinName })
                    //                        .Where(a => a.mbbbl.TransactionNo == PrescriptionNo && a.mbbb.LocationID == LocationID && a.mbbb.ItemID == row.ItemID 
                    //                                    && a.mbbb.NIE_BPOM == row.NIE_BPOM && a.mbbb.BatchID == row.BatchID && row.ExpiredDate.HasValue
                    //                                    && a.mbbb.ExpiredDate.Date == row.ExpiredDate.Value.Date)
                    //                        .GroupBy(m => new {m.mbbbl.MultiBatchBalanceBinID, m.mbbb.BinID, m.BinName })
                    //                        .Select(a => new
                    //                        {
                    //                            a.Key.BinID,
                    //                            a.Key.BinName,
                    //                            QtyOut = a.Sum(x => x.mbbbl.QtyOut) - a.Sum(x => x.mbbbl.QtyIn)
                    //                        })
                    //                        .Where(a => a.QtyOut > 0)
                    //                        .ToListAsync();                    
                    var item = await _context.Items.FirstOrDefaultAsync(a => a.ItemID == row.ItemID);
                    var bin = await _context.MultiBatchItemBins.FirstOrDefaultAsync(a => a.LocationID == LocationID && a.BinID == row.BinID);
                    
                    if (bin == null)
                    {
                        Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetDetailTransaction)} with result bin {null}");
                    }

                    query.Add(new DispensingItemBinDetailViewModel
                    {
                        ItemID = row.ItemID!,
                        ItemName = item!.ItemName,
                        NIE_BPOM = row.NIE_BPOM!,
                        Batch = row.BatchID!,
                        ExpiredDate = row.ExpiredDate,
                        Quantity = row.Quantity,
                        BinName = bin?.BinName,
                        BinID = row.BinID.ToString()!
                    });
                }
                Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetDetailTransaction)} is load from database with data {JsonSerializer.Serialize(query)}");

                #endregion
            }
            else
            {
                var ItemIDs = itemList.Where(il => il.isControlExpired).Select(il => il.ItemID).ToList();

                var mbbbRawData = await _context.MultiBatchBalanceBins
                                        .Join(_context.MultiBatchItemBins,
                                                mbbb => mbbb.BinID,
                                                mbib => mbib.BinID,
                                                (mbbb, mbib) => new { mbbb, mbib }
                                                )
                                        .Where(x => x.mbbb.LocationID == LocationID && x.mbbb.Quantity > 0)
                                        .ToListAsync();

                var mbbbJoined = mbbbRawData.Where(x => ItemIDs.Contains(x.mbbb.ItemID))
                                            .Select(x => new
                                            {
                                                x.mbbb.MultiBatchBalanceBinID,
                                                x.mbbb.ItemID,
                                                x.mbbb.NIE_BPOM,
                                                x.mbbb.BatchID,
                                                x.mbbb.ExpiredDate,
                                                x.mbbb.Quantity,
                                                x.mbib.BinName,
                                                x.mbib.BinID,
                                                x.mbbb.Barcode
                                            }).
                                            ToList();

                var itemmovement = await _context.ItemMovements.Where(a => a.TransactionNo == PrescriptionNo).ToListAsync();

                bool isReject = false;
                foreach (var item in itemList)
                {
                    if (item.isControlExpired)
                    {
                        decimal QtyReq = item.ResultQty;
                        var MatchedItems = mbbbJoined.Where(m => m.ItemID == item.ItemID).OrderBy(m => m.ExpiredDate).ToList();
                        var MatchedMovement = itemmovement.Where(m => m.ItemID == item.ItemID).FirstOrDefault();
                        if (MatchedItems == null || MatchedItems.Count < 1)
                        {
                            query.Add(new DispensingItemBinDetailViewModel
                            {
                                ItemID = item.ItemID,
                                ItemName = item.ItemName,
                                Quantity = 0
                            });
                            isReject = true;
                            ItemQtyReq[item.ItemID] = QtyReq;
                        }
                        else
                        {
                            foreach (var batch in MatchedItems)
                            {
                                var mbbbitem = await _context.MultiBatchBalanceBins.FirstOrDefaultAsync(m => m.MultiBatchBalanceBinID == batch.MultiBatchBalanceBinID);

                                if (batch.Quantity >= QtyReq)
                                {
                                    mbbbitem!.Quantity -= QtyReq;
                                    var newdata = new DispensingItemBinDetailViewModel
                                    {
                                        ItemID = item.ItemID,
                                        ItemName = item.ItemName,
                                        NIE_BPOM = batch.NIE_BPOM,
                                        Batch = batch.BatchID,
                                        ExpiredDate = batch.ExpiredDate,
                                        Quantity = QtyReq,
                                        BinName = batch.BinName,
                                        BinID = batch.BinID.ToString(),
                                    };
                                    UpdateDB_MB_MBBalance_MBBalanceLog_MBMovement(PrescriptionNo, item, mbbbitem, QtyReq, MatchedMovement!, LocationID, batch.BinID);
                                    query.Add(newdata);
                                    QtyReq = 0;
                                    break;
                                }
                                else
                                {
                                    QtyReq -= mbbbitem!.Quantity;
                                    var newdata = new DispensingItemBinDetailViewModel
                                    {
                                        ItemID = item.ItemID,
                                        ItemName = item.ItemName,
                                        NIE_BPOM = batch.NIE_BPOM,
                                        Batch = batch.BatchID,
                                        ExpiredDate = batch.ExpiredDate,
                                        Quantity = mbbbitem.Quantity,
                                        BinName = batch.BinName,
                                        BinID = batch.BinID.ToString(),
                                    };
                                    UpdateDB_MB_MBBalance_MBBalanceLog_MBMovement(PrescriptionNo, item, mbbbitem, mbbbitem.Quantity, MatchedMovement!, LocationID, batch.BinID);
                                    query.Add(newdata);
                                    mbbbitem.Quantity = 0;
                                }
                            }
                            if (QtyReq > 0)
                            {
                                ItemQtyReq[item.ItemID] = item.ResultQty;
                                isReject = true;
                            }
                        }
                    }                  
                }

                if (!isReject)
                {
                    //Check MultiBatchTemp first
                    var MBTempLoad = await _context.MultiBatchTemps.Where(m => m.TransactionNo == PrescriptionNo).ToListAsync();

                    // Update status of existing MultiBatchTemp items if items match
                    if (MBTempLoad != null && MBTempLoad.Any())
                    {
                        foreach (var item in itemList)
                        {                            
                            var matchedTempItems = MBTempLoad.Where(m => m.ItemID == item.ItemID).ToList();
                            foreach (var tempItem in matchedTempItems)
                            {
                                tempItem.Status = AppEnum.Status.DISPENSED.ToString();
                                tempItem.StatusByUserID = _UserID;
                                tempItem.StatusByDateTime = DateTime.Now;
                            }
                        }
                    }
                    await _context.SaveChangesAsync();
                    Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetDetailTransaction)} is saved to database");
                }
                else
                {
                    Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(GetDetailTransaction)} is reject because quantity is not enough");
                }
            }

            var groupquery = query.GroupBy(x => new { x.ItemID, x.ItemName })
                                .Select(f => new DispensingItemGroupViewModel
                                {
                                    ItemID = f.Key.ItemID,
                                    ItemName = f.Key.ItemName,
                                    ItemDetailDatas = f.Select(a => new DispensingItemDetailDataViewModel
                                    {
                                        NIE_BPOM = a.NIE_BPOM,
                                        Batch = a.Batch,
                                        ExpiredDate = a.ExpiredDate.HasValue ? a.ExpiredDate.Value.Date.ToString("MM/dd/yyyy") : string.Empty,
                                        Quantity = a.Quantity,
                                        BinName = a.BinName,
                                        BinID = a.BinID,
                                    }).ToList()
                                }).ToList();

            foreach (var item in groupquery)
            {
                ItemQtyReq.TryGetValue(item.ItemID, out decimal qty);
                item.ItemQtyReq = qty;
            }
            foreach(var item in itemList.Where(a => !a.isControlExpired))
            {
                groupquery.Add(new DispensingItemGroupViewModel
                {
                    ItemID = item.ItemID,
                    ItemName = item.ItemName,
                    QtyNonCE = item.ResultQty
                });
            }

            return groupquery;
        }

        private async Task<DispensingBinViewModel> GetAvaibleBinAndBinBalance(string PrescriptionNo, string LocationID, string ItemID)
        {
            var query = await (from mbblcbin in _context.MultiBatchBalanceBins
                                join mbbb in _context.MultiBatchBalances on new
                                {
                                    mbblcbin.LocationID,
                                    mbblcbin.ItemID,
                                    mbblcbin.NIE_BPOM,
                                    mbblcbin.BatchID,
                                    mbblcbin.ExpiredDate.Date
                                }
                                equals new
                                {
                                    mbbb.LocationID,
                                    mbbb.ItemID,
                                    mbbb.NIE_BPOM,
                                    mbbb.BatchID,
                                    mbbb.ExpiredDate.Date
                                }
                                join mbblcb in _context.MultiBatchItemBins on mbblcbin.BinID equals mbblcb.BinID
                                where mbblcbin.LocationID == LocationID && mbblcbin.ItemID == ItemID && mbblcbin.Quantity > 0 && mbbb.isOpen == true
                                select new
                                {
                                    mbblcbin.NIE_BPOM,
                                    mbblcbin.BatchID,
                                    ExpiredDate = mbblcbin.ExpiredDate.Date.ToString("MM/dd/yyyy"),
                                    mbblcbin.Quantity,
                                    mbblcbin.BinID,
                                    mbblcb.BinName,
                                    mbblcbin.Barcode
                                }
                                )
                                .ToListAsync();

            var groupquery = query.GroupBy(x => new { x.BinID, x.BinName })
                                    .Select(f => new DispensingBinListViewModel
                                    {
                                        BinID = f.Key.BinID.ToString(),
                                        BinName = f.Key.BinName,
                                        BinItemLists = f.Select(d => new DispensingBinItemDetailViewModel
                                        {
                                            NIE_BPOM = d.NIE_BPOM,
                                            Batch = d.BatchID,
                                            ExpiredDate = d.ExpiredDate,
                                            Quantity = d.Quantity,
                                            Barcode = d.Barcode
                                        })
                                        .OrderBy(a => a.ExpiredDate).ToList()
                                    }).OrderBy(a => a.BinID).ToList();

            return new DispensingBinViewModel
            {
                ItemID = ItemID,
                BinList = groupquery
            };
        }

        private void UpdateDB_MB_MBBalance_MBBalanceLog_MBMovement(string PrescriptionNo, PrescriptionItemDTO item, MultiBatchBalanceBin batch, decimal Qty, ItemMovement itemmovement, string LocationID, int BinID)
        {
            var NewMBItem = new MultiBatch
            {
                TransactionNo = PrescriptionNo,
                SequenceNo = item.SequenceNo,
                ReferenceNo = item.ReferenceNo,
                ReferenceSequenceNo = item.ReferenceSequenceNo,
                ItemID = item.ItemID,
                NIE_BPOM = batch.NIE_BPOM,
                BatchID = batch.BatchID,
                ExpiredDate = batch.ExpiredDate,
                Quantity = Qty,
                SRItemUnit = item.SRItemUnit,
                LastUpdatebyTime = DateTime.Now,
                LastUpdatebyID = _UserID,
                Status = AppEnum.Status.APPROVE.ToString(),
                StatusByDateTime = DateTime.Now,
                StatusByUserID = _UserID,
                Barcode = batch.Barcode,
                BinID = BinID
            };

            var NewMBMovement = new MultiBatchItemMovement
            {
                MultiBatch = NewMBItem,
                MovementID = itemmovement.MovementID,
                MovementDate = itemmovement.MovementDate,
                ServiceUnitID = LocationID,
                LocationID = LocationID,
                TransactionNo = NewMBItem.TransactionNo,
                SequenceNo = NewMBItem.SequenceNo,
                ItemID = NewMBItem.ItemID,
                QuantityIn = 0,
                QuantityOut = NewMBItem.Quantity,
                LastUpdateByDateTime = DateTime.Now,
                LastUpdateByUserID = _UserID
            };

            var NewMBBBlog = new MultiBatchBalanceBinLog
            {
                MultiBatchBalanceBinID = batch.MultiBatchBalanceBinID,
                QtyIn = 0,
                QtyOut = Qty,
                TransactionNo = PrescriptionNo,
                CreatedDate = DateTime.Now,
                CreatedBy = _UserID
            };

            NewMBItem.MultiBatchItemMovements.Add(NewMBMovement);
            _context.MultiBatches.Add(NewMBItem);
            _context.MultiBatchBalanceBinLogs.Add(NewMBBBlog);

            var existMBBalance = _context.MultiBatchBalances.Where(m => m.LocationID == LocationID && m.ItemID == item.ItemID
                                                                    && m.NIE_BPOM == batch.NIE_BPOM && m.BatchID == batch.BatchID
                                                                    && m.ExpiredDate == batch.ExpiredDate).FirstOrDefault();

            existMBBalance!.Balance -= Qty;
            existMBBalance.LastUpdateByTime = DateTime.Now;
            existMBBalance.LastUpdateByid = _UserID;
            existMBBalance.LastTransactionNo = PrescriptionNo;
        }
        #endregion

        #region DTO
        private class PrescriptionItemDTO
        {
            public bool IsApproval { get; set; }
            public string ItemID { get; set; } = null!;
            public string ItemName { get; set; } = null!;
            public string SequenceNo { get; set; } = null!;
            public string? ReferenceNo { get; set; }
            public string? ReferenceSequenceNo { get; set; }
            public string SRItemUnit { get; set; } = null!;
            public decimal ResultQty { get; set; }
            public bool isControlExpired { get; set; }
            }
        #endregion
    }
}