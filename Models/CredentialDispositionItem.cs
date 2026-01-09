using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialDispositionItem
{
    public string DispositionNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
