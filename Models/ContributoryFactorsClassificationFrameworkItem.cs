using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ContributoryFactorsClassificationFrameworkItem
{
    public string FactorID { get; set; } = null!;

    public string FactorItemID { get; set; } = null!;

    public string? FactorItemName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
