using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NosocomialMonitoringBedRest
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public bool? IsMobilization { get; set; }

    public bool? IsInjuryCare { get; set; }

    public string? SkinCondition { get; set; }

    public string? InjuryCondition { get; set; }

    public string? Fisiotherapi { get; set; }

    public string? Note { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? MonitoringByUserID { get; set; }

    public string? Mobilization { get; set; }

    public bool? IsSkinComplete { get; set; }

    public bool? IsSkinRed { get; set; }

    public bool? IsSkinNoBlister { get; set; }

    public bool? IsSkinWarm { get; set; }

    public bool? IsSkinHard { get; set; }

    public bool? IsSkinItchy { get; set; }

    public bool? IsInjuryBlister { get; set; }

    public bool? IsInjuryOpen { get; set; }

    public bool? IsInjuryToFat { get; set; }

    public bool? IsInjuryNekrosis { get; set; }

    public bool? IsInjuryToBone { get; set; }

    public bool? IsCulture { get; set; }

    public string? ParamedicID { get; set; }
}
