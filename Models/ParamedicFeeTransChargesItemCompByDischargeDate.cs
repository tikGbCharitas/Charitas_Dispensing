using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeTransChargesItemCompByDischargeDate
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public DateTime? DischargeDate { get; set; }

    public bool IsOrderRealization { get; set; }

    public string ParamedicID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public decimal? FeeAmount { get; set; }

    public bool? IsRefferal { get; set; }

    public bool? IsCalculatedInPercent { get; set; }

    public decimal? CalculatedAmount { get; set; }

    public bool? IsFree { get; set; }

    public DateTime? LastCalculatedDateTime { get; set; }

    public string? LastCalculatedByUserID { get; set; }

    public string? VerificationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsCalcDeductionInPercent { get; set; }

    public decimal? CalcDeductionAmount { get; set; }

    public decimal? DeductionAmount { get; set; }

    public int? JournalId { get; set; }

    public string OldParamedicID { get; set; } = null!;

    public bool IsModified { get; set; }

    public decimal PriceItem { get; set; }

    public decimal DiscountItem { get; set; }

    public string? TransactionNoRef { get; set; }

    public string? RegistrationNo { get; set; }

    public string? RegistrationNoMergeTo { get; set; }

    public DateTime? DischargeDateMergeTo { get; set; }

    public string? Notes { get; set; }

    public string? PaymentMethodName { get; set; }

    public string? SRPhysicianFeeCategory { get; set; }

    public string? SRParamedicFeeCaseType { get; set; }

    public string? SRParamedicFeeTeamStatus { get; set; }

    public string? SRParamedicFeeIsTeam { get; set; }

    public decimal? SumDeductionAmount { get; set; }

    public int? ParamedicFeeByServiceSettingID { get; set; }

    public string? SmfID { get; set; }

    public bool? IsGuarantorVerified { get; set; }

    public decimal? DiscountExtra { get; set; }

    public string? PaymentNoCash { get; set; }

    public string? PaymentNoAR { get; set; }

    public string? InvoicePaymentNo { get; set; }

    public bool? IsWriteOff { get; set; }

    public string? InvoiceWriteOffNo { get; set; }

    public decimal? PercentagePayment { get; set; }

    public DateTime? LastPaymentDate { get; set; }

    public string? PaymentNoGuarAR { get; set; }

    public string? InvoicePaymentNoGuar { get; set; }

    public decimal? PercentagePaymentAR { get; set; }

    public decimal? PercentagePaymentGuarAR { get; set; }

    public string? ChangeNote { get; set; }

    public decimal? SumDeductionAmountAfterTax { get; set; }

    public string? PaymentGroupNo { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserID { get; set; }

    public bool? IsForTakeOneHighest { get; set; }

    public decimal? PctgPropCash { get; set; }

    public decimal? PctgPropAR { get; set; }

    public decimal? PctgPropARGuar { get; set; }

    public bool? IsBrutoFromFeeAmount { get; set; }

    public decimal? FeeAmountBruto { get; set; }
}
