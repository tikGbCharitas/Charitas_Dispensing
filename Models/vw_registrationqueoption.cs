using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_registrationqueoption
{
    public string ServiceUnitID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string ParamedicName { get; set; } = null!;

    public DateTime ScheduleDate { get; set; }

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

    public string ServiceUnitName { get; set; } = null!;
}
