using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BpjsRujuk
{
    public string noRujukan { get; set; } = null!;

    public string? noSep { get; set; }

    public DateOnly? tglRujukan { get; set; }

    public DateOnly? tglRencanaKunjungan { get; set; }

    public string? ppkDirujuk { get; set; }

    public string? jnsPelayanan { get; set; }

    public string? catatan { get; set; }

    public string? diagRujukan { get; set; }

    public string? tipeRujukan { get; set; }

    public string? poliRujukan { get; set; }
}
