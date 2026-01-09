using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DocumentSignatureItem
{
    public string TransactionNo { get; set; } = null!;

    public decimal MinAmount { get; set; }

    public decimal MaxAmount { get; set; }

    public string? PositionAs1 { get; set; }

    public string? PositionAs2 { get; set; }

    public string? PositionAs3 { get; set; }

    public string? PositionAs4 { get; set; }

    public string? SignerBy1 { get; set; }

    public string? SignerBy2 { get; set; }

    public string? SignerBy3 { get; set; }

    public string? SignerBy4 { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
