using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ContributoryFactorsClassificationFrameworkItemComponent
{
    public string FactorID { get; set; } = null!;

    public string FactorItemID { get; set; } = null!;

    public string ComponentID { get; set; } = null!;

    public string? ComponentName { get; set; }

    public bool? IsAllowEdit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
