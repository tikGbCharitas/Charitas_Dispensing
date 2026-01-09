using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalBenefitRuleDefinition
{
    public long MedicalBenefitRuleDefinitionID { get; set; }

    public int MedicalBenefitInfoID { get; set; }

    public string? SREmploymentType { get; set; }

    public string? SREmployeeStatus { get; set; }

    public int? PositionGradeID { get; set; }

    public int? EmployeeGradeID { get; set; }

    public int? PersonID { get; set; }

    public int? AgeFrom { get; set; }

    public int? AgeTo { get; set; }

    public int? ServiceYearFrom { get; set; }

    public int? ServiceYearTo { get; set; }

    public bool? IsUnlimit { get; set; }

    public int? BasicSalaryFactor { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
