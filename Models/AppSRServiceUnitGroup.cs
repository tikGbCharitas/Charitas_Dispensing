using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppSRServiceUnitGroup
{
    public string SRServiceUnitGroupID { get; set; } = null!;

    public bool? IsSoapEntryTypeAssessment { get; set; }

    public bool? IsUseMedicalHist { get; set; }

    public bool? IsUseLocalist { get; set; }

    public bool? IsUseEducation { get; set; }

    public bool? IsUseDiagnoseTherapy { get; set; }

    public bool? IsUseOdontogram { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
