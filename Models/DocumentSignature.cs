using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DocumentSignature
{
    public string TransactionNo { get; set; } = null!;

    public string SRTransactionCode { get; set; } = null!;

    public string SRItemType { get; set; } = null!;

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
