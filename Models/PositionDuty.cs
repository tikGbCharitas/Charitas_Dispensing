using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionDuty
{
    public int PositionDutyID { get; set; }

    public int PositionID { get; set; }

    public string DutyName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
