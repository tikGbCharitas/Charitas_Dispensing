using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RiskFactor
{
    public string SRRiskFactorsType { get; set; } = null!;

    public string RiskFactorsID { get; set; } = null!;

    public string RiskFactorsName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
