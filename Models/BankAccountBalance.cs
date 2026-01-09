using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BankAccountBalance
{
    public int BalanceId { get; set; }

    public string BankId { get; set; } = null!;

    public string Month { get; set; } = null!;

    public string Year { get; set; } = null!;

    public decimal InitialBalance { get; set; }

    public decimal DebitAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal FinalBalance { get; set; }

    public virtual Bank Bank { get; set; } = null!;
}
