using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialCompetencyAssessment
{
    public string TransactionNo { get; set; } = null!;

    public string Confirmation { get; set; } = null!;

    public string ConfirmationResult { get; set; } = null!;

    public string Observation { get; set; } = null!;

    public string ObservationResult { get; set; } = null!;

    public string Question { get; set; } = null!;

    public string QuestionResult { get; set; } = null!;

    public string Exploration { get; set; } = null!;

    public string CodeOfEthics { get; set; } = null!;

    public string CodeOfEthicsResult { get; set; } = null!;

    public string? SRMedicalClinicalCompetence { get; set; }

    public string? SRMedicalGeneralCompetence { get; set; }

    public string? SRMedicalEthicalStanding { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
