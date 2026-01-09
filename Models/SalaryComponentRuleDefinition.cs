using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SalaryComponentRuleDefinition
{
    public long SalaryComponentRuleDefinitionID { get; set; }

    public int SalaryComponentID { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public int? OrganizationUnitID { get; set; }

    public string? SREmployeeStatus { get; set; }

    public int? PositionID { get; set; }

    public string? SRReligion { get; set; }

    public int? PersonID { get; set; }

    public string? SREmploymentType { get; set; }

    public int? PositionGradeID { get; set; }

    public string? SRMaritalStatus { get; set; }

    public string? ServiceYear { get; set; }

    public int? SalaryTableNumber { get; set; }

    public int? EmployeeGradeID { get; set; }

    public int? NoOfDependent { get; set; }

    public int? AttedanceMatrixID { get; set; }

    public decimal? NominalAmount { get; set; }

    public decimal? PercentageAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public int? PercentageComponentID { get; set; }

    public string? SREducationLevelID { get; set; }
}
