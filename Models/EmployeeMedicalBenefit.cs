using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeMedicalBenefit
{
    public long EmployeeMedicalBenefitID { get; set; }

    public int PersonID { get; set; }

    public int MedicalBenefitInfoID { get; set; }

    public int YearPeriodID { get; set; }

    public bool? IsUnlimited { get; set; }

    public string? SRMedicalPaidRules { get; set; }

    public string? GuarantorID { get; set; }

    public decimal? EmployeeBenefit { get; set; }

    public decimal? EmployeeUsedAmount { get; set; }

    public decimal? EmployeeAdjustmentAmount { get; set; }

    public decimal? EmployeeUnusedAmount { get; set; }

    public int? NoOfDependent { get; set; }

    public string? DependentGuarantorID { get; set; }

    public decimal? DependentBenefit { get; set; }

    public decimal? DependentUsedAmount { get; set; }

    public decimal? DependentAdjustmentAmount { get; set; }

    public decimal? DependentUnusedAmount { get; set; }

    public decimal? TotalBenefit { get; set; }

    public decimal? TotalUsedAmount { get; set; }

    public decimal? TotalAdjustmentAmount { get; set; }

    public decimal? TotalUnusedAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
