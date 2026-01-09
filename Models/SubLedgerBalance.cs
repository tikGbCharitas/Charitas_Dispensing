using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SubLedgerBalance
{
    public int SubLedgerBalanceId { get; set; }

    public int SubLedgerId { get; set; }

    public int ChartOfAccountId { get; set; }

    public string Month { get; set; } = null!;

    public string Year { get; set; } = null!;

    public decimal InitialBalance { get; set; }

    public decimal DebitAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal FinalBalance { get; set; }

    public virtual ChartOfAccount ChartOfAccount { get; set; } = null!;

    public virtual SubLedger SubLedger { get; set; } = null!;
}
