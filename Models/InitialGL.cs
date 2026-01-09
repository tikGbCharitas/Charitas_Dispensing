using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class InitialGL
{
    public string YearNo { get; set; } = null!;

    public string MonthNo { get; set; } = null!;

    public string AccountID { get; set; } = null!;

    public string SRAcctLevel { get; set; } = null!;

    public string SRAcctSubsidiary { get; set; } = null!;

    public string SRCurrency { get; set; } = null!;

    public decimal DebetAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal InitialRate { get; set; }

    public decimal DebetConvert { get; set; }

    public decimal CreditConvert { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
