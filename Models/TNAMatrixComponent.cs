using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TNAMatrixComponent
{
    public int TNAMatrixComponentID { get; set; }

    public string? TNAMatrixID { get; set; }

    public string? SRTNAType { get; set; }

    public string? SRTNAEmployeePosition { get; set; }

    public string? SRTNACostComponent { get; set; }

    public decimal? Price { get; set; }

    public string? CurrencyId { get; set; }

    public bool? IsMultipleByDay { get; set; }

    public bool? IsOptionalComponent { get; set; }
}
