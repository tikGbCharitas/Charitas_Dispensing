using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionLicense
{
    public int PositionLicenseID { get; set; }

    public int PositionID { get; set; }

    public string SRRequirement { get; set; } = null!;

    public string SRLicenseType { get; set; } = null!;

    public string? LicenseNotes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
