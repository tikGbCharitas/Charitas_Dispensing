using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ClosingWageTransaction
{
    public int PayrollPeriodID { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
