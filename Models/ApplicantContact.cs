using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApplicantContact
{
    public int ApplicantContactID { get; set; }

    public int ApplicantID { get; set; }

    public string SRContactType { get; set; } = null!;

    public string ContactValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
