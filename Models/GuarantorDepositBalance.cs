using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorDepositBalance
{
    public string GuarantorID { get; set; } = null!;

    public decimal BalanceAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
