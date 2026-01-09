using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NosocomialMonitoringInfu
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public string? SRIVCatheter { get; set; }

    public string? SRInfusSet { get; set; }

    public bool? IsSetBlood { get; set; }

    public string? SRInfusLocation { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsPain { get; set; }

    public bool? IsRedness { get; set; }

    public bool? IsFeelingHot { get; set; }

    public bool? IsSwollen { get; set; }

    public bool? IsPus { get; set; }

    public bool? IsKanulaCulture { get; set; }

    public string? ParamedicID { get; set; }

    public string? MedicineAndLiquid { get; set; }

    public string? MedicationMethod { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? InfusLocation { get; set; }

    public DateTime? ReleaseDateTime { get; set; }

    public string? ReleaseByParamedicID { get; set; }

    public string? Notes { get; set; }

    public string? LiquidType { get; set; }

    public bool? IsDirty { get; set; }

    public bool? IsHandHygiene { get; set; }

    public bool? IsTreatmentOfInfectedAreas { get; set; }

    public bool? IsAssessNotRemoveSoon { get; set; }

    public bool? IsReplacementOfAdministrationSet { get; set; }

    public bool? IsEducation { get; set; }

    public bool? IsDesinfectionHubCVCAlcohol { get; set; }

    public bool? IsTreatmentOfInsertionAreas { get; set; }

    public bool? IsDressingReplacementAsepticly { get; set; }

    public bool? IsReleaseUnUsageInfus { get; set; }
}
