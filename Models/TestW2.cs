using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TestW2
{
    public string? TransactionNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? ItemID { get; set; }

    public decimal? Qty { get; set; }

    public string? SRItemUnit { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? BatchNumber { get; set; }

    public string? MovementID { get; set; }

    public DateTime? MovementDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
