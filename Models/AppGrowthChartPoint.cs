using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppGrowthChartPoint
{
    public string ChartGroup { get; set; } = null!;

    public string ChartType { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string AgeGroup { get; set; } = null!;

    public string SeriesName { get; set; } = null!;

    public decimal XValue { get; set; }

    public double YValue { get; set; }
}
