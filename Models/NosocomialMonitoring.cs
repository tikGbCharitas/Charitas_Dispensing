using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NosocomialMonitoring
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public string MonitoringType { get; set; } = null!;

    public DateTime InstallationDateTime { get; set; }

    public DateTime? ReleaseDateTime { get; set; }

    public string? RoomID { get; set; }

    public string? Location { get; set; }

    public string? TypeOfInfus { get; set; }

    public string? FluidOther { get; set; }

    public string? TypeOfCatheter { get; set; }

    public string? InstallationByParamedicID { get; set; }

    public string? Antibiotic { get; set; }

    public string? Problem { get; set; }

    public string? Monitoring { get; set; }

    public string? TubeNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ReleaseByParamedicID { get; set; }

    public string? SREttType { get; set; }

    public string? DecubitusFromType { get; set; }

    public string? DecubitusFrom { get; set; }

    public string? OtherDrugs { get; set; }

    public bool? IsAssesNeeds { get; set; }

    public bool? IsInstallationbyTrainedPersonnel { get; set; }

    public bool? IsHandHygiene { get; set; }

    public bool? IsTechniqueSterile { get; set; }

    public bool? IsUseOfPPE { get; set; }

    public bool? IsSedation { get; set; }

    public bool? IsSkilledOfficer { get; set; }

    public bool? IsDisinfectTheInsertionArea { get; set; }

    public bool? IsOptimalInsertionAreaSelection { get; set; }

    public bool? IsAlcoholBasedChlorhexidine { get; set; }

    public bool? IsMaximumAPDUsage { get; set; }

    public bool? IsBathUsingAntisepticSoap { get; set; }

    public bool? IsShavingWithClipper { get; set; }

    public bool? IsNormalBloodSugar { get; set; }

    public bool? IsAnibiotic60minuteBeforeIncision { get; set; }

    public bool? IsHandHygieneWithSurgicalAntiseptic { get; set; }

    public bool? IsSterileInstrument { get; set; }

    public bool? IsUsingSkinAntisepticPreparation { get; set; }

    public bool? IsSterileOperationTechnique { get; set; }

    public bool? IsMobilePersonelSystemIsLimited { get; set; }

    public bool? IsTemperature19to24 { get; set; }

    public string? VenaType { get; set; }
}
