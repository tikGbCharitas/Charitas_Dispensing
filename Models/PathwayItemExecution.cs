using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PathwayItemExecution
{
    public string PathwayID { get; set; } = null!;

    public int PathwayItemSeqNo { get; set; }

    public int DayNo { get; set; }

    public string SRPathwayExecutionType { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
