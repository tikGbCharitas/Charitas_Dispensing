using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesItemCompGuarantor
{
    public string GuarantorID { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public decimal CoverageAmount { get; set; }

    public decimal CoverageDiscountAmount { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? Price { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? GrossDiscountAmount { get; set; }

    public decimal? GrossCitoAmount { get; set; }

    public decimal? CoverageAdjustmentAmount { get; set; }

    public bool? IsAllowVariable { get; set; }

    public decimal? ChargePrice { get; set; }

    public decimal? ChargeAmount { get; set; }

    public decimal? ChargeDiscountAmount { get; set; }

    public decimal? ChargeCitoAmount { get; set; }

    public decimal? ProportionalCash { get; set; }

    public decimal? ProportionalAR { get; set; }

    public string? SRRuleType { get; set; }

    public decimal? RuleAmount { get; set; }

    public bool? RuleAmountInPercent { get; set; }
}
