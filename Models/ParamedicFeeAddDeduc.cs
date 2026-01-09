using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeAddDeduc
{
    public string TransactionNo { get; set; } = null!;

    public DateOnly TransactionDate { get; set; }

    public string ParamedicID { get; set; } = null!;

    public string SRParamedicFeeAdjustType { get; set; } = null!;

    public string? Notes { get; set; }

    public decimal Amount { get; set; }

    public bool? IsApproved { get; set; }

    public string? VerificationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdatedByUserID { get; set; }

    public bool? IsIncludeInTaxCalc { get; set; }

    public string? TariffComponentID { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public string? ChartOfAccountTemplateId { get; set; }

    public string? PaymentGroupNo { get; set; }

    public decimal? Price { get; set; }
}
