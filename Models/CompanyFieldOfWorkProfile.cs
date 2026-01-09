using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CompanyFieldOfWorkProfile
{
    public int CompanyFieldOfWorkProfileID { get; set; }

    public int CompanyLaborProfileID { get; set; }

    public string CompanyFieldOfWorkProfileCode { get; set; } = null!;

    public string? CompanyFieldOfWorkProfileName { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
