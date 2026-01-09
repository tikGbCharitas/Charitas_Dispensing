using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalLicence
{
    public int PersonalLicenceID { get; set; }

    public int PersonID { get; set; }

    public string SRLicenceType { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string Note { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? LicenceFilePath { get; set; }

    public string? LFLastUpdateByID { get; set; }

    public DateTime? LFLastUpdateDate { get; set; }
}
