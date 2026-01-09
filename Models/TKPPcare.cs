using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TKPPcare
{
    public string TKPNo { get; set; } = null!;

    public string KodeTKP { get; set; } = null!;

    public string? Keterangan { get; set; }
}
