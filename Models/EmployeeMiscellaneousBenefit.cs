using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeMiscellaneousBenefit
{
    public int EmployeeMiscellaneousBenefitID { get; set; }

    public int PersonID { get; set; }

    public string SRMiscellaneousBenefit { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
