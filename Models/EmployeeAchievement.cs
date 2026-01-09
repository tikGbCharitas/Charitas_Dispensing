using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeAchievement
{
    public int EmployeeAchievementID { get; set; }

    public int PersonID { get; set; }

    public int AwardID { get; set; }

    public DateTime AwardDate { get; set; }

    public string? Achievement { get; set; }

    public decimal? FinancialValue { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
