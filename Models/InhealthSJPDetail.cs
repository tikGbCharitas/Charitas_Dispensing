using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class InhealthSJPDetail
{
    public string nosjp { get; set; } = null!;

    public string idsjp { get; set; } = null!;

    public DateTime? tanggalmasuk { get; set; }

    public DateTime? tanggalkeluar { get; set; }

    public string? kodejenpelruangrawat { get; set; }
}
