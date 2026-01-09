using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CompanyEducationProfile
{
    public int CompanyEducationProfileID { get; set; }

    public int CompanyLaborProfileID { get; set; }

    public string CompanyEducationProfileCode { get; set; } = null!;

    public string CompanyEducationProfileName { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
