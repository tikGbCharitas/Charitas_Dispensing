using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorBridging
{
    public string GuarantorID { get; set; } = null!;

    public string SRBridgingType { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsPercentageCoverageValue { get; set; }

    public decimal? CoverageValue { get; set; }

    public decimal? MarginValue { get; set; }

    public string? BridgingID { get; set; }

    public string? BridgingCode { get; set; }
}
