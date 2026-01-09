using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NosocomialMonitoringEtt
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public string? SREttType { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsLeukopenia { get; set; }

    public bool? IsLeukositosis { get; set; }

    public bool? IsSputum { get; set; }

    public bool? IsCough { get; set; }

    public bool? IsDipsnoe { get; set; }

    public bool? IsWetRonchi { get; set; }

    public bool? IsDesaturasi { get; set; }

    public bool? IsCulture { get; set; }

    public bool? IsRadiology { get; set; }

    public string? ParamedicID { get; set; }

    public string? Note { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsHandHygiene { get; set; }

    public bool? IsOralHygiene { get; set; }

    public bool? IsManagementOroAndEndo { get; set; }

    public bool? IsSedasitionVacation { get; set; }

    public bool? IsHeadPosition { get; set; }
}
