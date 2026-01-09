using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RiskGradingMtx
{
    public string SRClinicalImpact { get; set; } = null!;

    public string SRIncidentProbabilityFrequency { get; set; } = null!;

    public string SRIncidentFollowUp { get; set; } = null!;

    public string RiskGradingID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
