using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalBenefitInfo
{
    public int MedicalBenefitInfoID { get; set; }

    public string MedicalBenefitName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string GuarantorID { get; set; } = null!;

    public int MedicalPercentPaid { get; set; }

    public string SRMedicalPaidRules { get; set; } = null!;

    public decimal? MedicalPaidMoney { get; set; }

    public int? MedicalPaidFaktor { get; set; }

    public bool? IsEmploymentType { get; set; }

    public bool? IsSpecificEmployee { get; set; }

    public bool? IsEmployeeStatus { get; set; }

    public bool? IsPositionGrade { get; set; }

    public bool? IsAge { get; set; }

    public bool? IsRemunerationType { get; set; }

    public bool? IsEmployeeGrade { get; set; }

    public bool? IsServiceYear { get; set; }

    public int? SettlementRuleID { get; set; }

    public bool? IsUnlimitedFrequency { get; set; }

    public int? FrequencyValue { get; set; }

    public string SRUnusedBalance { get; set; } = null!;

    public decimal? MaxCarryOver { get; set; }

    public int? NoOfDependent { get; set; }

    public string DependentGuarantorID { get; set; } = null!;

    public int DependentPercentPaid { get; set; }

    public string? SRDependentPaidRules { get; set; }

    public int? DependentFromEmployeeBenefit { get; set; }

    public decimal? DependentAmountValue { get; set; }

    public int? DependentAmountFaktor { get; set; }

    public bool? IsUnlimitedFrequencyDependent { get; set; }

    public int? FrequencyValueDependent { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
