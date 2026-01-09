using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WorkProgramSpecificTarget
{
    public string? WorkProgramNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? WorkProgramSpecificTargetName { get; set; }

    public string? Note { get; set; }

    public decimal? IndexTarget { get; set; }
}
