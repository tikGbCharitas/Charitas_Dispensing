using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemPackage
{
    public string ItemID { get; set; } = null!;

    public string DetailItemID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public bool IsStockControl { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsExtraItem { get; set; }

    public decimal? DiscountValue { get; set; }

    public bool? IsDiscountInPercent { get; set; }
}
