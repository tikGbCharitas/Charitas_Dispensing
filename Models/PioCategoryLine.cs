using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PioCategoryLine
{
    public int PioNo { get; set; }

    public string SRPioCategory { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
