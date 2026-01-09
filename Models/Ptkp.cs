using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Ptkp
{
    public int PtkpID { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string SRTaxStatus { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
