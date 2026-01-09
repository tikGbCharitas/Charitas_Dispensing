using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SalaryComponent
{
    public int SalaryComponentID { get; set; }

    public string SalaryComponentCode { get; set; } = null!;

    public string SalaryComponentName { get; set; } = null!;

    public string SRSalaryType { get; set; } = null!;

    public string? SRSalaryCategory { get; set; }

    public string? SRIncomeTaxMethod { get; set; }

    public string? SRDeductionType { get; set; }

    public string? SRJamsostekType { get; set; }

    public decimal? Amount { get; set; }

    public double FaktorRule { get; set; }

    public string? FaktorRuleDisplay { get; set; }

    public int? SalaryComponentRoundingID { get; set; }

    public bool? DisplayInPaySlip { get; set; }

    public bool? DisplayInPayRekapReport { get; set; }

    public bool? IsOrganizationUnit { get; set; }

    public bool? IsEmployeeStatus { get; set; }

    public bool? IsPosition { get; set; }

    public bool? IsReligion { get; set; }

    public bool? IsEmployee { get; set; }

    public bool? IsEmploymentType { get; set; }

    public bool? IsPositionGrade { get; set; }

    public bool? IsMaritalStatus { get; set; }

    public bool? IsServiceYear { get; set; }

    public bool? IsSalaryTableNumber { get; set; }

    public bool? IsEmployeeGrade { get; set; }

    public bool? IsNoOfDependent { get; set; }

    public bool? IsAttedanceMatrixID { get; set; }

    public bool? IsComponent1 { get; set; }

    public bool? IsComponent2 { get; set; }

    public bool? IsComponent3 { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsKWI { get; set; }

    public bool? IsEducationLevel { get; set; }
}
