using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeRemun
{
    public string ParamedicID { get; set; } = null!;

    public int Year { get; set; }

    public int Month { get; set; }

    public decimal? Claim { get; set; }

    public decimal? PercentOfClaim { get; set; }

    public decimal? FeeClaim { get; set; }

    public decimal? Additional { get; set; }

    public decimal? Deduction { get; set; }

    public decimal? DeductionConvertion { get; set; }

    public decimal? DeductionAnesthetic { get; set; }

    public decimal? DeductionResult { get; set; }

    public decimal? Performance { get; set; }

    public string? VerificationNo { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastCalculatedByUserID { get; set; }

    public DateTime? LastCalculatedDateTime { get; set; }
}
