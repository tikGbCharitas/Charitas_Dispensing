using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialEthicsQuestionnarie
{
    public string TransactionNo { get; set; } = null!;

    public string SREthicsCredentialQuestion { get; set; } = null!;

    public string Result { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
