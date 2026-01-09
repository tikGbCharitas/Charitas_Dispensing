using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CompanyLaborProfile
{
    public int CompanyLaborProfileID { get; set; }

    public string CompanyLaborProfileCode { get; set; } = null!;

    public string CompanyLaborProfileName { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
