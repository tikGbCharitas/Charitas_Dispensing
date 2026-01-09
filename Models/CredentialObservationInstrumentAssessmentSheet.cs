using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialObservationInstrumentAssessmentSheet
{
    public string TransactionNo { get; set; } = null!;

    public int QuestionnaireItemID { get; set; }

    public bool IsEval1 { get; set; }

    public bool IsEval2 { get; set; }

    public bool IsEval3 { get; set; }

    public bool IsEval4 { get; set; }

    public bool IsEval5 { get; set; }

    public string Notes { get; set; } = null!;

    public decimal? Score { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
