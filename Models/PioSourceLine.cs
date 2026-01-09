using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PioSourceLine
{
    public int PioNo { get; set; }

    public string SRPioSource { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
