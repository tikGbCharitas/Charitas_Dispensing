using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicScheduleDate
{
    public string ServiceUnitID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string PeriodYear { get; set; } = null!;

    public DateTime ScheduleDate { get; set; }

    public string OperationalTimeID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? CloseRegistrationAll { get; set; }

    public bool? CloseRegistrationOnline { get; set; }
}
