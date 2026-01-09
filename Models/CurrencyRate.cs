using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CurrencyRate
{
    public string CurrencyID { get; set; } = null!;

    public string CurrencyName { get; set; } = null!;

    public decimal CurrencyRate1 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
