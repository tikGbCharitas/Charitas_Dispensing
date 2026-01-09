using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionEmploymentCompany
{
    public int PositionEmploymentCompanyID { get; set; }

    public int PositionID { get; set; }

    public string SRRequirement { get; set; } = null!;

    public int? YearOfService { get; set; }

    public int? PositionGradeID { get; set; }

    public string? Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
