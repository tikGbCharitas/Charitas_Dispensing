using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorDepositMovement
{
    public Guid MovementID { get; set; }

    public DateTime MovementDate { get; set; }

    public string GuarantorID { get; set; } = null!;

    public string TransactionCode { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public decimal? InitialBalance { get; set; }

    public decimal? Debet { get; set; }

    public decimal? Credit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
