using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Guarantor
{
    public string GuarantorID { get; set; } = null!;

    public string GuarantorName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string SRGuarantorType { get; set; } = null!;

    public string ContractNumber { get; set; } = null!;

    public DateTime? ContractStart { get; set; }

    public DateTime? ContractEnd { get; set; }

    public string ContractSummary { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public bool IsActive { get; set; }

    public string SRBusinessMethod { get; set; } = null!;

    public string SRTariffType { get; set; } = null!;

    public string? SRGuarantorRuleType { get; set; }

    public bool IsValueInPercent { get; set; }

    public decimal AmountValue { get; set; }

    public decimal AdminPercentage { get; set; }

    public decimal AdminAmountLimit { get; set; }

    public string StreetName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public int? ChartOfAccountId { get; set; }

    public int? SubLedgerId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsIncludeItemMedical { get; set; }

    public bool? IsIncludeItemNonMedical { get; set; }

    public bool? IsIncludeItemOptic { get; set; }

    public bool? IsIncludeItemMedicalToGuarantor { get; set; }

    public bool? IsIncludeItemNonMedicalToGuarantor { get; set; }

    public bool? IsIncludeItemOpticToGuarantor { get; set; }

    public bool? IsCoverInpatient { get; set; }

    public bool? IsCoverOutpatient { get; set; }

    public decimal? ItemMedicMarginPercentage { get; set; }

    public string? ItemMedicMarginID { get; set; }

    public decimal? ItemNonMedicMarginPercentage { get; set; }

    public string? ItemNonMedicMarginID { get; set; }

    public string? GuarantorHeaderID { get; set; }

    public bool? IsIncludeAdminValue { get; set; }

    public decimal? AdminValueMinimum { get; set; }

    public bool? IsGlobalPlafond { get; set; }

    public bool? IsAdminFromTotal { get; set; }

    public decimal? AdminPercentageOp { get; set; }

    public decimal? AdminAmountLimitOp { get; set; }

    public decimal? AdminValueMinimumOp { get; set; }

    public int? ChartOfAccountIdTemporary { get; set; }

    public int? SubledgerIdTemporary { get; set; }

    public bool? IsItemRuleUsingDefaultAmountValue { get; set; }

    public decimal? OutpatientAmountValue { get; set; }

    public decimal? EmergencyAmountValue { get; set; }

    public string? SRPaymentType { get; set; }

    public string? SRPhysicianFeeType { get; set; }

    public int? ChartOfAccountIdDeposit { get; set; }

    public int? SubledgerIdDeposit { get; set; }

    public int? TermOfPayment { get; set; }

    public int? ChartOfAccountIdOverPayment { get; set; }

    public int? SubledgerIdOverPayment { get; set; }

    public string? SRPhysicianFeeCategory { get; set; }

    public int? ChartOfAccountIdCostParamedicFee { get; set; }

    public int? SubledgerIdCostParamedicFee { get; set; }

    public bool? IsExcessPlafonToDiscount { get; set; }

    public string? SRProdiaTariffType { get; set; }

    public string? VirtualAccountNo { get; set; }

    public string? ReportRLID { get; set; }

    public int? RlMasterReportItemID { get; set; }

    public bool? IsCoverAllAdminCosts { get; set; }

    public string? ScopeOfCooperation { get; set; }

    public string? OutpatientProcedure { get; set; }

    public string? InpatientProcedure { get; set; }

    public string? FileRequirements { get; set; }

    public string? ExceptionsNotCovered { get; set; }

    public string? SRDiscountReasonGroup { get; set; }

    public string? SRDiscountReason { get; set; }

    public string? SRGuarantorIncomeGroup { get; set; }
}
