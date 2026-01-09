using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialInvitationTeam
{
    public string InvitationNo { get; set; } = null!;

    public int PersonID { get; set; }

    public string SRCredentialingTeamPosition { get; set; } = null!;

    public string InvitationLetterNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
