using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OtherBudgetServiceUnit
{
    public int OtherBudgetServiceUnitID { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? SROtherBudget { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
