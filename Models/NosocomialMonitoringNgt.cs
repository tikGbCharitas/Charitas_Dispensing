using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NosocomialMonitoringNgt
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public string? Replacement { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsPus { get; set; }

    public bool? IsPain { get; set; }

    public bool? IsHeadache { get; set; }

    public bool? IsNoseClogged { get; set; }

    public bool? IsPainSwallow { get; set; }

    public bool? IsPharingRedness { get; set; }

    public bool? IsCough { get; set; }

    public bool? IsTransillumination { get; set; }

    public bool? IsCulture { get; set; }

    public string? ParamedicID { get; set; }

    public string? Note { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
