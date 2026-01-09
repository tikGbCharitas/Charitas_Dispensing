using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialCompetencyAssessmentExploration
{
    public string TransactionNo { get; set; } = null!;

    public string SRCompetencyAssessmentExplor { get; set; } = null!;

    public bool IsResult { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
