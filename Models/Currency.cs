using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Currency
{
    public string CurrencyID { get; set; } = null!;

    public string CurrencyName { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
