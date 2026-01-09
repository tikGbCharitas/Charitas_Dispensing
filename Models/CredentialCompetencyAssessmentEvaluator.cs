using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialCompetencyAssessmentEvaluator
{
    public string TransactionNo { get; set; } = null!;

    public int EvaluatorID { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
