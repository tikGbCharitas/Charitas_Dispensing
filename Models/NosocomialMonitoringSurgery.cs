using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NosocomialMonitoringSurgery
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public string? SRExudateCharacter { get; set; }

    public bool? IsAfDrain { get; set; }

    public bool? IsAfSuture { get; set; }

    public bool? IsRedness { get; set; }

    public bool? IsSwollen { get; set; }

    public bool? IsPain { get; set; }

    public bool? IsFeelingHot { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsPus { get; set; }

    public string? ParamedicID { get; set; }

    public string? Note { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsCulture { get; set; }

    public string? InjuryCondition { get; set; }

    public bool? IsHandHygieneWithSurgicalAntiseptic { get; set; }

    public bool? IsSterileInstrument { get; set; }

    public bool? IsUsingSkinAntisepticPreparation { get; set; }

    public bool? IsSterileOperationTechnique { get; set; }

    public bool? IsMobilePersonelSystemIsLimited { get; set; }

    public bool? IsTemperature19to24 { get; set; }

    public bool? IsWoundClosed2x24 { get; set; }

    public bool? IsWoundTreatmentUsingNaCl { get; set; }

    public bool? IsUsingAPDForWoundTreatment { get; set; }

    public bool? IsCheckPatientNutrition { get; set; }
}
