using AvicennaDispensing.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Identity.Client;
using System.Globalization;
using System.Text.Json;

namespace AvicennaDispensing.ViewModels
{
    public class DispensingViewModel
    {
        public class DispensingDetailViewModel
        {
            public string PrescriptionNo { get; set; } = null!;
            public string? RegistrationNo { get; set; }
            public string? Patient { get; set; }
            public string? Age { get; set; }
            public string? MedicalNo { get; set; }
            public string? Sex { get; set; }
            public string? Height { get; set; }
            public string? Weight { get; set; }
            public bool Approved { get; set; }
            public string? DeliverDateTime { get; set; }
            public List<DispensingItemGroupViewModel>? ItemGroupsDatas { get; set; }
            public class DispensingItemGroupViewModel
            {
                public string ItemID { get; set; } = null!;
                public string ItemName { get; set; } = null!;
                public decimal? ItemQtyReq { get; set; } = null!;
                public decimal? QtyNonCE { get; set; } //For ControlExpired is False
                public List<DispensingItemDetailDataViewModel> ItemDetailDatas { get; set; } = new();
            }
            public class DispensingItemDetailDataViewModel
            {
                public string NIE_BPOM { get; set; } = null!;
                public string Batch { get; set; } = null!;
                public string ExpiredDate { get; set; } = null!;
                public decimal? Quantity { get; set; }
                public string? BinName { get; set; }
                public string? BinID { get; set; }
                public string? Barcode { get; set; }
            }
        }
        public class DispensingListViewModel
        {
            public int DispensingListID { get; set; }
            public string PrescriptionNo { get; set; } = null!;
            public string? Patient { get; set; }
            public string? RegistrationNo { get; set; }
            public string? Age { get; set; }
            public string? MedicalNo { get; set; }
            public string? Sex { get; set; }
            public string? Height { get; set; }
            public string? Weight { get; set; }
            public bool? Approved { get; set; }
            public string? DeliverDateTime { get; set; }
        }
        public class DispensingBinViewModel
        {
            public string PrescriptionNo { get; set; } = null!;
            public string ItemID { get; set; } = null!;
            public string ItemName { get; set; } = null!;
            public JsonElement FrontEndData { get;set; }
            public decimal FrontEndTotalQty { get; set; } = 0;
            public List<DispensingBinListViewModel> BinList { get; set; } = null!;
            public class DispensingBinListViewModel
            {
                public string BinID { get; set; } = null!;
                public string BinName { get; set; } = null!;
                public List<DispensingBinItemDetailViewModel> BinItemLists { get; set; } = new();
            }
            public class DispensingBinItemDetailViewModel
            {
                public string NIE_BPOM { get; set; } = null!;
                public string Batch { get; set; } = null!;
                public string ExpiredDate { get; set; } = null!;
                public decimal? Quantity { get; set; }
                public string? Barcode { get; set; }
            }
        }
        public class DispensingItemBinDetailViewModel
        {
            public string ItemID { get; set; } = null!;
            public string ItemName { get; set; } = null!;
            public string NIE_BPOM { get; set; } = null!;
            public string Batch { get; set; } = null!;
            public DateTime? ExpiredDate { get; set; }
            public decimal? Quantity { get; set; }
            public string? BinName { get; set; }
            public string BinID { get; set; } = null!;
        }
    }
}
