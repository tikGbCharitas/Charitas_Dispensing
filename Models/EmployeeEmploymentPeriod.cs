using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeEmploymentPeriod
{
    public int EmployeeEmploymentPeriodID { get; set; }

    public int PersonID { get; set; }

    public string SREmploymentType { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public int? CompanyLaborProfileID { get; set; }

    public int? RecruitmentPlanID { get; set; }

    public int? PositionGradeID { get; set; }

    public string? SREducationLevel { get; set; }
}
