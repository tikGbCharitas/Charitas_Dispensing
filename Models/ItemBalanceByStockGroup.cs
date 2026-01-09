using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemBalanceByStockGroup
{
    public string SRStockGroup { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal? Minimum { get; set; }

    public decimal? Maximum { get; set; }

    public decimal? Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
