using Microsoft.Identity.Client;
using System.Globalization;

namespace AvicennaDispensing.ViewModels
{
    public class BinOpnameViewModel
    {
        public class BinOpnameList
        {
            public string TransactionNo { get; set; } = null!;
            public DateTime TransactionDate { get; set; }
            public string? SortType { get; set; }
            public List<FilterListStatus> FilterList { get; set; } = null!;
        }
        public class FilterListStatus
        {
            public string? FilterName { get; set; }
            public bool? isApproved { get; set; }
        }

        public class PageDetail
        {
            public string TransactionNo { get; set; } = null!;
            public List<FilterListStatus> FilterList { get; set; } = null!;
            public string? SortID { get; set; } = null!;
            public string SortType { get; set; } = null!;
            public string? DataMode { get; set; }
            public List<FilterDetail>? DetailList { get; set; }
            public class FilterDetail
            {
                public string ItemID { get; set; } = null!;
                public string ItemName { get; set; } = null!;
                public string? NIE_BPOM { get; set; }
                public string? BatchID { get; set; }
                public DateTime? ExpiredDate { get; set; }
                public decimal? TotalQuantity { get; set; }
                public bool isOpen { get; set; } = false;
                public int BinID { get; set; }
                public string BinName { get; set; } = null!;
                public decimal? BinQty { get; set; }
                public bool isControlExpired { get; set; }
            }
        }
    }
}
