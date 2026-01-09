using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EpisodeDiagnose
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string DiagnoseID { get; set; } = null!;

    public string SRDiagnoseType { get; set; } = null!;

    public string DiagnosisText { get; set; } = null!;

    public string? MorphologyID { get; set; }

    public string ParamedicID { get; set; } = null!;

    public bool IsAcuteDisease { get; set; }

    public bool IsChronicDisease { get; set; }

    public bool IsOldCase { get; set; }

    public bool IsConfirmed { get; set; }

    public bool IsVoid { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ExternalCauseID { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? IdentifierID { get; set; }

    public string? IdentifierStatus { get; set; }

    public DateTime? SatuSehatRequestDate { get; set; }

    public DateTime? SatuSehatResponseDate { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
