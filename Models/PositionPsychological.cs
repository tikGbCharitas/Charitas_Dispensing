using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionPsychological
{
    public int PositionPsychologicalID { get; set; }

    public int PositionID { get; set; }

    public string SRPsychological { get; set; } = null!;

    public string SROperandType { get; set; } = null!;

    public string PsychologicalValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
