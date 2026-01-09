using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppAutoNumberLast
{
    public string SRAutoNumber { get; set; } = null!;

    public DateTime EffectiveDate { get; set; }

    public string DepartmentInitial { get; set; } = null!;

    public int YearNo { get; set; }

    public int MonthNo { get; set; }

    public int DayNo { get; set; }

    public int? LastNumber { get; set; }

    public string? LastCompleteNumber { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
