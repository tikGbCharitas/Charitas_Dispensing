using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PayrollPeriod
{
    public int PayrollPeriodID { get; set; }

    public string PayrollPeriodCode { get; set; } = null!;

    public string PayrollPeriodName { get; set; } = null!;

    public string SRPaySequent { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime PayDate { get; set; }

    public int SPTYear { get; set; }

    public int SPTMonth { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public int? WageProcessTypeID { get; set; }

    public bool? IsMoslemTHR { get; set; }
}
