using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SurgicalPackage
{
    public string PackageID { get; set; } = null!;

    public string PackageName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
