using AspNetCoreGeneratedDocument;
using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using AvicennaDispensing.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Threading.Tasks;

namespace AvicennaDispensing.Controllers
{
    public class ServiceUnitTransactionEntryController : BaseController
    {
        public ServiceUnitTransactionEntryController(ApplicationDbContext context) : base(context)
        {
            
        }
        public async Task<IActionResult> Index()
        {
            string LocationID = User.FindFirst(ClaimTypesCustom.Service_Unit)!.Value;

            var BinList = await _context.MultiBatchItemBins.Where(a => a.LocationID == LocationID).ToListAsync();
            onView();
            return View(BinList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetBinItem(string BinID)
        {
            string LocationID = User.FindFirst(ClaimTypesCustom.Service_Unit)!.Value;
            List<ServiceUnitTransactionEntryViewModel.BinItem> query = await _context.MultiBatchBalanceBins
                                                            .Join(_context.Items,
                                                                mbb => mbb.ItemID,
                                                                i => i.ItemID,
                                                                (mbb, i) => new ServiceUnitTransactionEntryViewModel.BinItem
                                                                { 
                                                                    MultiBatchBalanceBin = mbb,
                                                                    ItemName = i.ItemName 
                                                                })
                                                            .Where(a => a.MultiBatchBalanceBin.LocationID == LocationID && a.MultiBatchBalanceBin.BinID.ToString() == BinID)
                                                            .ToListAsync();
            return PartialView("_BinItem", query);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetRegNo(string RegistrationNo)
        {
            var query = await _context.Registrations
                            .Join(_context.Patients, r => r.PatientID, p => p.PatientID,
                                (r, p) => new { r, p })
                            .Join(_context.Paramedics, rp => rp.r.ParamedicID, m => m.ParamedicID,
                                (rp, m) => new ServiceUnitTransactionEntryViewModel.RegistartionDetail 
                                { 
                                    Registration = rp.r, 
                                    Patient = rp.p, 
                                    ParamedicName = m.ParamedicName 
                                }
                                )
                            .FirstOrDefaultAsync(a => a.Registration!.RegistrationNo == RegistrationNo.Trim());
            if(query != null)
            {
                return Json(new { success = true, data = query });
            }
            else
            {
                return Json(new { success = false });
            }
        }

        #region CRUD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit()
        {
            string LocationID = User.FindFirst(ClaimTypesCustom.Service_Unit)!.Value;

            var BinList = await _context.MultiBatchItemBins.Where(a => a.LocationID == LocationID).ToListAsync();
            onEdit();
            return View("Index", BinList);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cancel()
        {
            string LocationID = User.FindFirst(ClaimTypesCustom.Service_Unit)!.Value;

            var BinList = await _context.MultiBatchItemBins.Where(a => a.LocationID == LocationID).ToListAsync();
            onSaveCancel();
            return View("Index", BinList);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(string toolbarData)
        {
            //var BinList = await _context.MultiBatchItemBins.Where(a => a.LocationID == LocationID).ToListAsync();

            //var mbexists = await _context.MultiBatchTemps.Where(a => a.TransactionNo == )

            onSaveCancel();
            //return View("Index", BinList);
            return View("Index");
        }
        #endregion
    }
}
