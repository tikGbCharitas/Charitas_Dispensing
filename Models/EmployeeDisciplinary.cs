using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeDisciplinary
{
    public int EmployeeDisciplinaryID { get; set; }

    public int PersonID { get; set; }

    public string SRWarningLevel { get; set; } = null!;

    public DateTime IncidentDate { get; set; }

    public DateTime DateIssue { get; set; }

    public string? Violation { get; set; }

    public string? EffectViolation { get; set; }

    public string? AdviceGiven { get; set; }

    public string? SanctionGiven { get; set; }

    public string? SRViolationDegree { get; set; }

    public string? SRViolationType { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
