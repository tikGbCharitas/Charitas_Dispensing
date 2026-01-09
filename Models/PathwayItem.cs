using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PathwayItem
{
    public string PathwayID { get; set; } = null!;

    public int PathwayItemSeqNo { get; set; }

    public string? ItemID { get; set; }

    public string AssesmentGroupName { get; set; } = null!;

    public string AssesmentName { get; set; } = null!;

    public decimal CoverageValue1 { get; set; }

    public decimal CoverageValue2 { get; set; }

    public decimal CoverageValue3 { get; set; }

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
