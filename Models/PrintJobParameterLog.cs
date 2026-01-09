using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PrintJobParameterLog
{
    public long PrintNo { get; set; }

    public string Name { get; set; } = null!;

    public string? ValueString { get; set; }

    public decimal? ValueNumeric { get; set; }

    public DateTime? ValueDateTime { get; set; }
}
