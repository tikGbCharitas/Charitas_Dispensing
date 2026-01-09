using AvicennaDispensing.ViewModels.Shared;

namespace AvicennaDispensing.ViewModels
{
    public class BinTransferViewModel
    {
        public class BinItemDetail
        {
            public int MultiBatchBalanceBinID { get; set; }
            public int BinID { get; set; }
            public string BinName { get; set; } = null!;
            public string ItemID { get; set; } = null!;
            public string ItemName { get; set; } = null!;
            public string NIE_BPOM { get; set; } = null!;
            public string BatchID { get; set; } = null!;
            public string ExpiredDate { get; set; } = null!;
            public decimal Quantity { get; set; }
            public string? Barcode { get; set; }
            public bool IsSelected { get; set; }
        }

        public class BinItemDetailGrouped
        {
            public string ItemID { get; set; } = null!;
            public string ItemName { get; set; } = null!;
            public decimal TotalQuantity { get; set; }
            public int VariantCount { get; set; }
        }

        public class BinDetail
        {
            public int BinID { get; set; }
            public string BinName { get; set; } = null!;
            public int ItemCount { get; set; }
        }

        public class IndexViewModel
        {
            public LocationViewModel? Locations { get; set; }
        }

        public class TransferResultViewModel
        {
            public bool Success { get; set; }
            public string Message { get; set; } = null!;
            public int TransferredItemsCount { get; set; }
            public List<string>? Errors { get; set; }
        }
    }
}
