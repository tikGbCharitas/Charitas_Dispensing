using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Pathway
{
    public string PathwayID { get; set; } = null!;

    public string PathwayName { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public decimal CoverageValue1 { get; set; }

    public decimal CoverageValue2 { get; set; }

    public decimal CoverageValue3 { get; set; }

    public int ALOS { get; set; }

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
