using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BudgetRealizationPlanItem
{
    public string BudgetRealizationPlanNo { get; set; } = null!;

    public string? BudgetType { get; set; }

    public string? BudgetLine { get; set; }

    public decimal? Qty { get; set; }

    public string? SRItemUnit { get; set; }

    public decimal? ConversionFactor { get; set; }

    public decimal? Price { get; set; }

    public decimal? QtyBalance { get; set; }

    public decimal? PriceBalance { get; set; }

    public string? Note { get; set; }
}
