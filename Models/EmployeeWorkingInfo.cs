using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeWorkingInfo
{
    public int PersonID { get; set; }

    public DateTime JoinDate { get; set; }

    public int? SupervisorId { get; set; }

    public string SREmployeeStatus { get; set; } = null!;

    public string SREmployeeType { get; set; } = null!;

    public int? PositionGradeID { get; set; }

    public string SRRemunerationType { get; set; } = null!;

    public string? AbsenceCardNo { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsKWI { get; set; }

    public decimal? GradeYear { get; set; }

    public string? SREducationLevel { get; set; }

    public DateTime? ResignDate { get; set; }

    public string? SRResignReason { get; set; }

    public int? CredentialSupervisorId { get; set; }

    public string? SREmployeeMedicType { get; set; }
}
