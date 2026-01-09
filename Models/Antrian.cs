using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Antrian
{
    public string tipe { get; set; } = null!;

    public string lantai { get; set; } = null!;

    public string ruang { get; set; } = null!;

    public string registrationno { get; set; } = null!;

    public DateTime? scantime { get; set; }

    public DateTime? calltime { get; set; }

    public DateTime? donetime { get; set; }

    public string? username { get; set; }

    public string? status { get; set; }
}
