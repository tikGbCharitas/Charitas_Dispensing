using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OperationalTime
{
    public string OperationalTimeID { get; set; } = null!;

    public string OperationalTimeName { get; set; } = null!;

    public string StartTime1 { get; set; } = null!;

    public string EndTime1 { get; set; } = null!;

    public string StartTime2 { get; set; } = null!;

    public string EndTime2 { get; set; } = null!;

    public string StartTime3 { get; set; } = null!;

    public string EndTime3 { get; set; } = null!;

    public string StartTime4 { get; set; } = null!;

    public string EndTime4 { get; set; } = null!;

    public string StartTime5 { get; set; } = null!;

    public string EndTime5 { get; set; } = null!;

    public string OperationalTimeBackcolor { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
