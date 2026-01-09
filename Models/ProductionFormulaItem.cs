using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProductionFormulaItem
{
    public string FormulaID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsConsumables { get; set; }
}
