using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BudgetPeriodeSetting
{
    public int ID { get; set; }

    public string? Periode { get; set; }

    public DateTime? LimitDate { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
