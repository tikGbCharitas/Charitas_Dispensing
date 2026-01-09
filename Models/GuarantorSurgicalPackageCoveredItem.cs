using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorSurgicalPackageCoveredItem
{
    public string GuarantorID { get; set; } = null!;

    public string PackageID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal CoveredAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
