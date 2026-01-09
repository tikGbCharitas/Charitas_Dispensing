using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class IncentiveDetail
{
    public int IncentiveDetailID { get; set; }

    public int IcentiveID { get; set; }

    public bool? IsByEmployeeType { get; set; }

    public string? SREmployeeTypeID { get; set; }

    public bool? IsByPositionLevel { get; set; }

    public string? SRPositionLevelID { get; set; }

    public bool? IsByServiceYear { get; set; }

    public decimal? ServiceYearFrom { get; set; }

    public decimal? ServiceYearTo { get; set; }

    public decimal Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
