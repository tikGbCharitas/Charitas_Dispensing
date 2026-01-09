using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PpiNeedlePunctured
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string OfficerName { get; set; } = null!;

    public DateTime DatePunctured { get; set; }

    public string PuncturedAreas { get; set; } = null!;

    public string CausePunctured { get; set; } = null!;

    public bool? IsBlood { get; set; }

    public bool? IsFluidSperm { get; set; }

    public bool? IsVaginalSecretions { get; set; }

    public bool? IsCerebrospinal { get; set; }

    public bool? IsUrine { get; set; }

    public bool? IsFaeces { get; set; }

    public bool? IsOfficerHiv { get; set; }

    public bool? IsOfficerHbv { get; set; }

    public bool? IsOfficerHcv { get; set; }

    public string OfficerImunizationHistory { get; set; } = null!;

    public string Chronology { get; set; } = null!;

    public string MedicalNo { get; set; } = null!;

    public string PatientName { get; set; } = null!;

    public string Diagnose { get; set; } = null!;

    public bool? IsPatientHiv { get; set; }

    public bool? IsPatientHbv { get; set; }

    public bool? IsPatientHcv { get; set; }

    public string PatientImunizationHistory { get; set; } = null!;

    public string KnownBy { get; set; } = null!;

    public DateTime? FollowUpDate { get; set; }

    public string? FollowUp { get; set; }

    public string? FollowUpBy { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? VerifiedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
