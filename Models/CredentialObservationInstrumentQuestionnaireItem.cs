using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialObservationInstrumentQuestionnaireItem
{
    public int QuestionnaireItemID { get; set; }

    public int QuestionnaireID { get; set; }

    public string QuestionCode { get; set; } = null!;

    public string QuestionNo { get; set; } = null!;

    public string QuestionName { get; set; } = null!;

    public string QuestionGroupName { get; set; } = null!;

    public int? QuestionnaireItemParentID { get; set; }

    public string? QuestionLevel { get; set; }

    public bool IsDetail { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
