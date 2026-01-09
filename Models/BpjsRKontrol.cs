using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BpjsRKontrol
{
    public string noSuratKontrol { get; set; } = null!;

    public string noSEP { get; set; } = null!;

    public string? kodeDokter { get; set; }

    public string? poliKontrol { get; set; }

    public DateOnly? tglRencanaKontrol { get; set; }
}
