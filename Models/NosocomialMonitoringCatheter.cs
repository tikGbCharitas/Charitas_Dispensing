using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NosocomialMonitoringCatheter
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public string? SRGeneralChateterNo { get; set; }

    public string? SRSiliconChateterNo { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsDisuria { get; set; }

    public bool? IsPain { get; set; }

    public bool? IsPyuria { get; set; }

    public bool? IsHematuria { get; set; }

    public bool? IsUrineCulture { get; set; }

    public string? ParamedicID { get; set; }

    public string? Note { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsUrineBagChange { get; set; }

    public string? FixationFluid { get; set; }

    public bool? IsHandHygiene { get; set; }

    public bool? IsAfterDefecation { get; set; }

    public bool? IsUrineBagNotOnTheFloor { get; set; }

    public bool? IsTheUrineBagIsLowerThanTheBladder { get; set; }

    public bool? IsPositionHoseIsNotFoldedAndDrainageClose { get; set; }

    public bool? IsRemoveImmediatelyIfNoLongerNeeded { get; set; }
}
