using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WorkProgram
{
    public string WorkProgramNo { get; set; } = null!;

    public string? TransactionCode { get; set; }

    public string? WorkProgramType { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? WorkProgramName { get; set; }

    public string? KPI { get; set; }

    public string? WorkProgramYear { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ProjectOwner { get; set; }

    public string? ProjectLeader { get; set; }

    public bool? IsApprove { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public string? VoidByUserID { get; set; }

    public string? Note { get; set; }

    public bool? IsApproveAssessment { get; set; }

    public string? ApprovedAssessmentByUserID { get; set; }

    public DateTime? ApprovedAssessmentDateTime { get; set; }
}
