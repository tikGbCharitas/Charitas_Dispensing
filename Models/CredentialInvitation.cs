using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialInvitation
{
    public string InvitationNo { get; set; } = null!;

    public DateTime InvitationDate { get; set; }

    public string SRProfessionGroup { get; set; } = null!;

    public string LetterNo { get; set; } = null!;

    public DateTime ScheduleDate { get; set; }

    public string? CredentialingLocation { get; set; }

    public string? ParticipantLetterNo { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
