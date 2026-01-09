using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialObservationInstrumentQuestionnaire
{
    public int QuestionnaireID { get; set; }

    public string QuestionnaireCode { get; set; } = null!;

    public string QuestionnaireName { get; set; } = null!;

    public string SRClinicalWorkArea { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
