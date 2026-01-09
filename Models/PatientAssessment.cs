using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientAssessment
{
    public string RegistrationInfoMedicID { get; set; } = null!;

    public string PatientID { get; set; } = null!;

    public string SRServiceUnitGroup { get; set; } = null!;

    public DateTime AssessmentDateTime { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public bool IsAutoAnamnesis { get; set; }

    public string? AllowAnamnesisSource { get; set; }

    public string? Hpi { get; set; }

    public string? Medikamentosa { get; set; }

    public string? ReviewOfSystem { get; set; }

    public string? PhysicalExam { get; set; }

    public string? OtherExam { get; set; }

    public string? Diagnose { get; set; }

    public string? Therapy { get; set; }

    public string? Education { get; set; }

    public byte[]? Genogram { get; set; }

    public string? Notes { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? SRAssessmentType { get; set; }

    public string? AnamnesisNotes { get; set; }

    public bool? IsInitialAssessment { get; set; }

    public int? EstimatedDayInPatient { get; set; }

    public string? Prognosis { get; set; }

    public string? MeasuredGoals { get; set; }

    public string? FollowUpPlanType { get; set; }

    public string? ConsulToType { get; set; }

    public string? ConsulTo { get; set; }

    public string? InpatientIndication { get; set; }

    public string? ControlPlan { get; set; }

    public string? JobHistNotes { get; set; }

    public string? HighRiskCriteria { get; set; }
}
