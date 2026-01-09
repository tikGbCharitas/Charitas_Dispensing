using AvicennaDispensing.ViewModels.Shared;

namespace AvicennaDispensing.ViewModels
{
    public class OpenBatchViewModel
    {
        public string SelectionType { get; set; } = "List";
        public bool isTransactionProceed { get; set; } = false;
        public List<ItemDetailViewModel> ItemDetail { get; set; } = null!;
        public List<BinViewModel> ItemBin { get; set; } = null!;
        public LocationViewModel? Locations { get; set; }
    }

    public class ItemDetailViewModel
    {
        public string ItemID { get; set; } = null!;
        public string? BatchID { get; set; }
        public decimal? Balance { get; set; }
        public string? ExpiredDate { get; set; }
        public string? NIE_BPOM { get; set; }
        public bool isOpen { get; set; }
        public string? Barcode { get; set; }
        public decimal? ConvertionFactor { get; set; }
        public string? SRPurchaseUnit { get; set; }
        public string? SRItemUnit { get; set; }
        public string? SRUnit { get; set; }
        public string? ItemName { get; set; }
        public string? LocationName { get; set; }
        public decimal? OpenQty { get; set; } //For Open Batch Quantity by Transaction
        public int? BinID { get; set; }
        public string? BinName { get; set; }
        public decimal BinQty { get; set; }
        public string? isModified { get; set; }
    }

    public class BinViewModel
    {
        public int BinID { get; set; }
        public string? BinName { get; set; }
    }
}
