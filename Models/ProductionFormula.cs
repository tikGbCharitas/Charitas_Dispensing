using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProductionFormula
{
    public string FormulaID { get; set; } = null!;

    public string? FormulaName { get; set; }

    public string? ItemID { get; set; }

    public decimal? Qty { get; set; }

    public string? Notes { get; set; }

    public bool IsCostInPercentage { get; set; }

    public decimal CostAmount { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
