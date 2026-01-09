using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DietLiquidPatientItem
{
    public string TransactionNo { get; set; } = null!;

    public string DietTime { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal? Qty { get; set; }

    public string? SRItemUnit { get; set; }

    public string? Notes { get; set; }

    public string? FoodID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
