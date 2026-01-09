using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesItemGuarantor
{
    public string GuarantorID { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Price { get; set; }

    public bool IsInclude { get; set; }

    public string SRGuarantorRuleType { get; set; } = null!;

    public decimal RuleAmount { get; set; }

    public bool RuleAmountInPercent { get; set; }

    public decimal GrossAmount { get; set; }

    public decimal GrossDiscountAmount { get; set; }

    public decimal GrossCitoAmount { get; set; }

    public bool IsAdminCalculation { get; set; }

    public decimal GrossAdmAmount { get; set; }

    public string Notes { get; set; } = null!;

    public decimal CoverageAmount { get; set; }

    public decimal CoverageDiscountAmount { get; set; }

    public decimal CoverageAdmAmount { get; set; }

    public string IntermBillNo { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public decimal? CoverageAdjustmentAmount { get; set; }

    public string? PaymentNoAdjustment { get; set; }

    public decimal? CoverageExessToDiscountAdmAmount { get; set; }

    public decimal? CoverageAdjustmentAdmAmount { get; set; }

    public decimal? ChargePrice { get; set; }

    public decimal? ChargeAmount { get; set; }

    public decimal? ChargeDiscountAmount { get; set; }

    public decimal? ChargeCitoAmount { get; set; }

    public bool? IsPackage { get; set; }

    public bool? IsPackageDetail { get; set; }

    public string? PackageReferenceNo { get; set; }

    public string? PackageReferenceSequenceNo { get; set; }

    public decimal? ProportionalCash { get; set; }

    public decimal? ProportionalAR { get; set; }

    public string? PaymentNo { get; set; }
}
