using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialCompetencyAssessmentDt
{
    public string TransactionNo { get; set; } = null!;

    public string SRMedicalCompetencyAssessmentDt { get; set; } = null!;

    public string? SRMedicalCompetencyAsstResult { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
