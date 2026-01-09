using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeePositionGrade
{
    public long EmployeePositionGradeID { get; set; }

    public int? PersonID { get; set; }

    public string? SREducationLevel { get; set; }

    public DateTime? ValidFrom { get; set; }

    public int? PositionGradeID { get; set; }

    public int? GradeYear { get; set; }

    public string? SRDecreeType { get; set; }

    public string? DecreeNo { get; set; }

    public string? PositionName { get; set; }

    public DateTime? NextProposalDate { get; set; }

    public int? NextPositionGradeID { get; set; }

    public int? NextGradeYear { get; set; }

    public string? SRDecreeTypeNext { get; set; }

    public string? NextPositionName { get; set; }

    public string? SRDp3 { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
