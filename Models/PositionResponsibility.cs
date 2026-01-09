using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionResponsibility
{
    public int PositionResponsibilityID { get; set; }

    public int PositionID { get; set; }

    public string ResponsibilityName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
