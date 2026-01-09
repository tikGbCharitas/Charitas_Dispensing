using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SSLogSumary
{
    public int ID { get; set; }

    public string? RegistrationNo { get; set; }

    public string? EncounterID { get; set; }

    public string? EncounterArrivalStart { get; set; }

    public string? EncounterArrivalEnd { get; set; }

    public string? EncounterInProgressID { get; set; }

    public string? EncounterInProgressStart { get; set; }

    public string? EncounterInProgressEnd { get; set; }

    public string? EncounterInProgressStatus { get; set; }

    public string? EncounterInProgressNote { get; set; }

    public string? EncounterDischargeID { get; set; }

    public string? EncounterDischargeStart { get; set; }

    public string? EncounterDischargeEnd { get; set; }

    public string? EncounterInDischargesStatus { get; set; }

    public string? EncounterInDischargesNote { get; set; }

    public string? EncounterFinishID { get; set; }

    public string? EncounterFinishStart { get; set; }

    public string? EncounterFinishEnd { get; set; }

    public string? EncounterFinishStatus { get; set; }

    public string? EncounterFinishNote { get; set; }

    public DateTime? LastCreateDateEncounter { get; set; }

    public DateTime? LastUpdateDateEncounter { get; set; }

    public string? EncounterNote { get; set; }

    public string? LastStatusEncounter { get; set; }

    public int? ErrorEncounterCount { get; set; }

    public DateTime? LastCreateDateCondDiagnosis { get; set; }

    public DateTime? LastUpdateDateCondDiagnosis { get; set; }

    public string? CondDiagnosisNote { get; set; }

    public string? LastStatusCondDiagnosis { get; set; }

    public int? ErrorCondDiagnosisCount { get; set; }

    public DateTime? LastCreateDateCondDischarge { get; set; }

    public DateTime? LastUpdateDateCondDischarge { get; set; }

    public string? CondDischargeNote { get; set; }

    public string? LastStatusCondDischarge { get; set; }

    public int? ErrorCountCondDischarge { get; set; }
}
