using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PpiProcedureSurveillance
{
    public string BookingNo { get; set; } = null!;

    public bool? IsRiskFactorAge { get; set; }

    public bool? IsRiskFactorNutrient { get; set; }

    public bool? IsRiskFactorObesity { get; set; }

    public bool? IsDiabetes { get; set; }

    public bool? IsHypertension { get; set; }

    public bool? IsHiv { get; set; }

    public bool? IsHbv { get; set; }

    public bool? IsHcv { get; set; }

    public string? SRProcedureClassification { get; set; }

    public string? SRTypesOfSurgery { get; set; }

    public string? SRRiskCategory { get; set; }

    public string? SRWoundClassification { get; set; }

    public string? SRAsaScore { get; set; }

    public string? SRTTime { get; set; }

    public string? Culturs { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
