using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeVerification
{
    public string VerificationNo { get; set; } = null!;

    public DateOnly VerificationDate { get; set; }

    public string ParamedicID { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public short TaxPeriod { get; set; }

    public decimal? VerificationAmount { get; set; }

    public decimal? TaxAmount { get; set; }

    public bool IsVoid { get; set; }

    public bool IsApproved { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? RegistrationNo { get; set; }

    public string? PaymentNo { get; set; }

    public decimal? VerificationTaxAmount { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserID { get; set; }

    public decimal? SumDeductionAmountAfterTax { get; set; }

    public DateTime? PlanningPaymentDate { get; set; }
}
