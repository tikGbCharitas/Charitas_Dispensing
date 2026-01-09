using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ContributoryFactorsClassificationFramework
{
    public string FactorID { get; set; } = null!;

    public string? FactorName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
