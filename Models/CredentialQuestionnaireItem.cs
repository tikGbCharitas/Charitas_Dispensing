using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialQuestionnaireItem
{
    public int QuestionnaireItemID { get; set; }

    public int QuestionnaireID { get; set; }

    public string QuestionCode { get; set; } = null!;

    public string QuestionNo { get; set; } = null!;

    public string QuestionName { get; set; } = null!;

    public string SRCredentialQuestionLevel { get; set; } = null!;

    public string SRCredentialActionType { get; set; } = null!;

    public bool IsDetail { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
