using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BloodBalance
{
    public string SRBloodSource { get; set; } = null!;

    public string SRBloodSourceFrom { get; set; } = null!;

    public string BagNo { get; set; } = null!;

    public decimal Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
