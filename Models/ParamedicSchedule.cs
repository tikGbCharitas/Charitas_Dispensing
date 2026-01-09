using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicSchedule
{
    public string ServiceUnitID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string PeriodYear { get; set; } = null!;

    public int? ExamDuration { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? ChatbotAllocation { get; set; }

    public int? BpjsAllocation { get; set; }

    public string? SRQueueType { get; set; }

    public virtual Paramedic Paramedic { get; set; } = null!;
}
