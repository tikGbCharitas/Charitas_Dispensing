using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialProcessDocument
{
    public string TransactionNo { get; set; } = null!;

    public string DocumentItemID { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
