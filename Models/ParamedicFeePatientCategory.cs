using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeePatientCategory
{
    public string ParamedicID { get; set; } = null!;

    public string SRPatientCategory { get; set; } = null!;

    public bool IsParamedicFeeUsePercentage { get; set; }

    public decimal ParamedicFeeAmount { get; set; }

    public decimal ParamedicFeeAmountReferral { get; set; }

    public bool IsDeductionFeeUsePercentage { get; set; }

    public decimal DeductionFeeAmount { get; set; }

    public decimal DeductionFeeAmountReferral { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
