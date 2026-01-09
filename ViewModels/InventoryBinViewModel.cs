using AvicennaDispensing.Models;
using AvicennaDispensing.ViewModels.Shared;
using System.Globalization;

namespace AvicennaDispensing.ViewModels
{
    public class InventoryBinViewModel
    {
        public class ItemList
        {
            public int MultiBatchBalanceBinID { get; set; }

            public string BinName { get; set; } = null!;

            public string ItemID { get; set; } = null!;

            public string ItemName { get; set; } = null!;

            public string NIE_BPOM { get; set; } = null!;

            public string BatchID { get; set; } = null!;

            public string ExpiredDate { get; set; } = null!;

            public decimal BinQty { get; set; }
            public decimal? EditBinQty { get; set; }

            public decimal? MaxBinQty { get; set; }
            public string? Barcode { get; set; }
            public bool isOpen { get; set; }
            public bool? isUnlock { get; set; }
        }
        public class LocationDetail
        {
            public string LocationID { get; set; } = null!;
            public string LocationName { get; set; } = null!;
        }
        public class IndexViewModel
        {
            public LocationViewModel? Locations { get; set; }
            public List<ItemList>? Items { get; set; }
        }
        public class BinMasterViewModel
        {
            public List<MultiBatchItemBin>? Bins { get; set; }
            public LocationViewModel? Locations { get; set; }
        }
    }
}