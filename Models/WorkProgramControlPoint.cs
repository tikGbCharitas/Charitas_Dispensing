using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WorkProgramControlPoint
{
    public int WorkProgramControlPointNo { get; set; }

    public string? WorkProgramNo { get; set; }

    public string? WorkProgramSpecificTargetSqNo { get; set; }

    public string? WorkProgramSpecificTargetCoreSqNo { get; set; }

    public string? Description { get; set; }

    public string? ControlPointPath { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
