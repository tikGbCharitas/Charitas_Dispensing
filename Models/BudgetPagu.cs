using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BudgetPagu
{
    public string BudgetPaguID { get; set; } = null!;

    public string? ServiceUnitID { get; set; }

    public string? PeriodYear { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? Note { get; set; }

    public bool? IsInventory { get; set; }
}
