using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WageTransactionItem
{
    public long WageTransactionItemID { get; set; }

    public long WageTransactionID { get; set; }

    public int SalaryComponentID { get; set; }

    public decimal Qty { get; set; }

    public decimal NominalAmount { get; set; }

    public string SRCurrencyCode { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public decimal CurrencyAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
