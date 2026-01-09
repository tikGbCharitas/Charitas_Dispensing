using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemConsumption
{
    public string ItemID { get; set; } = null!;

    public string DetailItemID { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
