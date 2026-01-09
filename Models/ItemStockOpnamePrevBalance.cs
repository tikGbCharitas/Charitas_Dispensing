using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemStockOpnamePrevBalance
{
    public string TransactionNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public decimal? CostPrice { get; set; }
}
