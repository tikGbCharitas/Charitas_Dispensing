using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeProgressiveTax
{
    public int CounterID { get; set; }

    public decimal MinAmount { get; set; }

    public decimal MaxAmount { get; set; }

    public decimal Percentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? PercentageNonNpwp { get; set; }
}
