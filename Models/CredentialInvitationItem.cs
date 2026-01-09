using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialInvitationItem
{
    public string InvitationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
