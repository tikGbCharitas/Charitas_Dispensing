using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BudgetPaguComponent
{
    public string? BudgetPaguID { get; set; }

    public string? ItemGroupID { get; set; }

    public decimal? Amount { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
