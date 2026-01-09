using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalDischargeSummary
{
    public string RegistrationNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ChiefComplaint { get; set; }

    public string? HistOfPresentIllness { get; set; }

    public string? Komorbiditas { get; set; }

    public string? PhysicalExam { get; set; }

    public string? AncillaryExam { get; set; }

    public string? MedicalProcedures { get; set; }

    public string? ProcedureID { get; set; }

    public string? Medications { get; set; }

    public string? AdmittingDiagnoseID1 { get; set; }

    public string? AdmittingDiagnoseName1 { get; set; }

    public string? AdmittingDiagnoseID2 { get; set; }

    public string? AdmittingDiagnoseName2 { get; set; }

    public string? FinalDiagnoseID1 { get; set; }

    public string? FinalDiagnoseName1 { get; set; }

    public string? FinalDiagnoseID2 { get; set; }

    public string? FinalDiagnoseName2 { get; set; }

    public string? FinalDiagnoseID3 { get; set; }

    public string? FinalDiagnoseName3 { get; set; }

    public string? PresentStatus { get; set; }

    public string? SuggestionFollowUp { get; set; }

    public string? TreatmentIndications { get; set; }

    public string? PastMedicalHistory { get; set; }

    public string? ProcedureName { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string? DischargeTime { get; set; }

    public string? ParamedicID { get; set; }

    public string? ParamedicName { get; set; }

    public string? SRUnitIntended { get; set; }

    public string? SRDischargeMethod { get; set; }

    public string? SRDischargeCondition { get; set; }
}
