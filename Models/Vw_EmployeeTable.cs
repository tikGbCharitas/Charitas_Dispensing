using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Vw_EmployeeTable
{
    public int PersonID { get; set; }

    public string EmployeeNumber { get; set; } = null!;

    public string? EmployeeName { get; set; }

    public int SupervisorId { get; set; }

    public string SREmployeeType { get; set; } = null!;

    public string SRRemunerationType { get; set; } = null!;

    public int OrganizationUnitID { get; set; }

    public int SubOrganizationUnitID { get; set; }

    public string SRPaymentFrequency { get; set; } = null!;

    public string SRTaxStatus { get; set; } = null!;

    public string SREmployeeStatus { get; set; } = null!;

    public int PositionID { get; set; }

    public string SRReligion { get; set; } = null!;

    public string SREmploymentType { get; set; } = null!;

    public int PositionGradeID { get; set; }

    public int PositionLevelID { get; set; }

    public string SRMaritalStatus { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public DateTime BirthDate { get; set; }

    public decimal? ServiceYear { get; set; }

    public string? ServiceYearText { get; set; }

    public string EmployeeLevel { get; set; } = null!;

    public int SalaryTableNumber { get; set; }

    public int EmployeeGradeID { get; set; }

    public int NoOfDependent { get; set; }

    public int IsKWI { get; set; }

    public string SREducationLevel { get; set; } = null!;

    public decimal? GradeYear { get; set; }

    public string CoverageClass { get; set; } = null!;

    public string CoverageClassBPJS { get; set; } = null!;

    public string SRGenderType { get; set; } = null!;

    public string? PatientID { get; set; }

    public DateTime? ResignDate { get; set; }

    public string? SRResignReason { get; set; }

    public int IsBPJS { get; set; }

    public int IsBPJSKesehatan { get; set; }

    public int? BPJSUncoveredNo { get; set; }

    public int? BPJSCoveredNo { get; set; }

    public decimal? ServiceMonthThr { get; set; }

    public int? ServiceMonthPPH { get; set; }

    public int IsJP { get; set; }

    public string? AbsenceCardNo { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string EmployeeTypePayroll { get; set; } = null!;

    public bool? IsSalaryManaged { get; set; }
}
