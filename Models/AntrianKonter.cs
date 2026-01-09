using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AntrianKonter
{
    public string tipe { get; set; } = null!;

    public string lantai { get; set; } = null!;

    public string ruang { get; set; } = null!;

    public string? lastregno { get; set; }

    public string? lastuser { get; set; }

    public DateTime? lastcalltime { get; set; }

    public DateTime? lastdonetime { get; set; }

    public string? laststatus { get; set; }
}
