using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialProcessTeam
{
    public string TransactionNo { get; set; } = null!;

    public int PersonID { get; set; }

    public int PositionID { get; set; }

    public string SRCredentialingTeamPosition { get; set; } = null!;

    public string AreasOfExpertise { get; set; } = null!;

    public string? InvitationLetterNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? MinutesOfMeeting { get; set; }

    public bool? IsAttend { get; set; }
}
