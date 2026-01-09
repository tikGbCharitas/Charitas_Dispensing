using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BpjsCMG
{
    public string NoSEP { get; set; } = null!;

    public string KodeCMG { get; set; } = null!;

    public decimal? TariffCMG { get; set; }

    public string? DeskripsiCMG { get; set; }

    public string? TipeCMG { get; set; }

    public bool? IsOptionCMG { get; set; }
}
