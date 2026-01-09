using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitKlinikRonald
{
    public string ServiceUnitID { get; set; } = null!;

    public string ServiceUnitName { get; set; } = null!;

    public string? Notes { get; set; }

    public string? Shortcodes { get; set; }

    public int? penjamin { get; set; }
}
