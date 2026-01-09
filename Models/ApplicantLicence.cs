using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApplicantLicence
{
    public int ApplicantLicenceID { get; set; }

    public int ApplicantID { get; set; }

    public string SRLicenceType { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string Note { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
