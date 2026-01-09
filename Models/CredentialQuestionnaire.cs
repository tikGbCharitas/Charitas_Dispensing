using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialQuestionnaire
{
    public int QuestionnaireID { get; set; }

    public string QuestionnaireCode { get; set; } = null!;

    public string QuestionnaireName { get; set; } = null!;

    public string SRProfessionGroup { get; set; } = null!;

    public string SRClinicalWorkArea { get; set; } = null!;

    public string SRClinicalAuthorityLevel { get; set; } = null!;

    public string? Info1 { get; set; }

    public string? Info2 { get; set; }

    public string? Info3 { get; set; }

    public string? Info4 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
