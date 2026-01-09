using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Incentive
{
    public int IcentiveID { get; set; }

    public string IncentiveName { get; set; } = null!;

    public int SalaryComponentID { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
