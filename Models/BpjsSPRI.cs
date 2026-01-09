using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BpjsSPRI
{
    public string noSPRI { get; set; } = null!;

    public string? noKartu { get; set; }

    public string? kodeDokter { get; set; }

    public string? poliKontrol { get; set; }

    public DateOnly? tglRencanaKontrol { get; set; }
}
