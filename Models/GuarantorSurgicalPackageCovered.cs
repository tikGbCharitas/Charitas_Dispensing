using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorSurgicalPackageCovered
{
    public string GuarantorID { get; set; } = null!;

    public string PackageID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
