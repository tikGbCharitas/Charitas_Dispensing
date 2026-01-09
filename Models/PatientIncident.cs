using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientIncident
{
    public string PatientIncidentNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string RoomID { get; set; } = null!;

    public string? BedID { get; set; }

    public string IncidentLocation { get; set; } = null!;

    public string ServiceUnitIDInCharge { get; set; } = null!;

    public DateTime IncidentDateTime { get; set; }

    public DateTime ReportingDateTime { get; set; }

    public string? IncidentName { get; set; }

    public string? Chronology { get; set; }

    public string SRIncidentType { get; set; } = null!;

    public string SRIncidentGroup { get; set; } = null!;

    public string SRClinicalImpact { get; set; } = null!;

    public string SRIncidentProbabilityFrequency { get; set; } = null!;

    public string? Handling { get; set; }

    public string? SRIncidentHandledBy { get; set; }

    public string SRIncidentFollowUp { get; set; } = null!;

    public DateOnly? FollowUpDate { get; set; }

    public string ReportedByUserID { get; set; } = null!;

    public string InsertByUserID { get; set; } = null!;

    public DateTime InsertDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? SRIncidentOccurredOn { get; set; }

    public string? IncidentOccurredOnName { get; set; }

    public string? SRIncidentOccurredInPatientsWith { get; set; }

    public string? IncidentOccurredInPatientsWithName { get; set; }

    public bool? IsOccurInOtherUnits { get; set; }

    public string? OccurInOtherUnitsNotes { get; set; }

    public bool? IsApproved { get; set; }

    public string? ApprovedByUserID { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? PatientID { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Sex { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public bool? NonPatient { get; set; }

    public bool? IsVerified { get; set; }

    public string? VerifiedByUserID { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? ServiceUnitIncidentLocationID { get; set; }

    public string? ParamedicID { get; set; }

    public bool? IsRiskManagement { get; set; }
}
