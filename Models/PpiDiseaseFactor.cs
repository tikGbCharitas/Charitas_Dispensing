using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PpiDiseaseFactor
{
    public string RegistrationNo { get; set; } = null!;

    public string? SRDiseaseFactorsHbsAg { get; set; }

    public string? SRDiseaseFactorsAntiHcv { get; set; }

    public string? SRDiseaseFactorsAntiHiv { get; set; }

    public string? OtherDiseaseFactors { get; set; }

    public string? Leukocyte { get; set; }

    public string? Led { get; set; }

    public string? Gds { get; set; }

    public string? RadiologyResult { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
