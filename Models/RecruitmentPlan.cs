using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RecruitmentPlan
{
    public int RecruitmentPlanID { get; set; }

    public string RecruitmentPlanName { get; set; } = null!;

    public int PositionID { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public int NumberOfRequestedEmployees { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? Notes { get; set; }
}
