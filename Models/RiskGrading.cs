using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RiskGrading
{
    public string RiskGradingID { get; set; } = null!;

    public string RiskGradingName { get; set; } = null!;

    public string RiskGradingColor { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
