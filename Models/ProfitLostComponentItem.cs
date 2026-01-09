using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProfitLostComponentItem
{
    public string? ProfitLostComponentNo { get; set; }

    public string? SRProfitLostComponent { get; set; }

    public decimal? Price { get; set; }
}
