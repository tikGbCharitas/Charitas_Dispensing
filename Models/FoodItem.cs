using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class FoodItem
{
    public string FoodID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Qty { get; set; }

    public string? SRItemUnit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
