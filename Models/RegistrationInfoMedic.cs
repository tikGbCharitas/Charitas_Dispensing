using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationInfoMedic
{
    public string RegistrationInfoMedicID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string SRMedicalNotesInputType { get; set; } = null!;

    public DateTime DateTimeInfo { get; set; }

    public string Info1 { get; set; } = null!;

    public string Info2 { get; set; } = null!;

    public string Info3 { get; set; } = null!;

    public string Info4 { get; set; } = null!;

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? Info1Log { get; set; }

    public string? Info2Log { get; set; }

    public string? Info3Log { get; set; }

    public string? Info4Log { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? AttendingNotes { get; set; }

    public bool? IsInformConcern { get; set; }

    public string? ParamedicID { get; set; }

    public DateTime? ApprovedDatetime { get; set; }

    public bool? IsApproved { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsPRMRJ { get; set; }

    public string? PpaInstruction { get; set; }

    public string? ReferenceNo { get; set; }

    public bool? IsCreatedByUserDpjp { get; set; }

    public string? SRUserType { get; set; }

    public string? PrescriptionCurrentDay { get; set; }

    public string? ReferenceType { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
