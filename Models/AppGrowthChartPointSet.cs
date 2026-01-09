using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppGrowthChartPointSet
{
    public string ChartGroup { get; set; } = null!;

    public string ChartType { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string AgeGroup { get; set; } = null!;

    public string SeriesName { get; set; } = null!;

    public int SeriesWidth { get; set; }

    public bool IsVisible { get; set; }
}
