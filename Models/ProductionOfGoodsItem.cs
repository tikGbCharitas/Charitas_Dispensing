using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProductionOfGoodsItem
{
    public string ProductionNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public decimal CostPrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? PriceInBaseUnit { get; set; }

    public bool? IsConsumables { get; set; }
}
