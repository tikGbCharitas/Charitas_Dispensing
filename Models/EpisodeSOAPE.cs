using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EpisodeSOAPE
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public DateTime SOAPEDate { get; set; }

    public string SOAPETime { get; set; } = null!;

    public string Subjective { get; set; } = null!;

    public string Objective { get; set; } = null!;

    public string Assesment { get; set; } = null!;

    public string Planning { get; set; } = null!;

    public string Evaluation { get; set; } = null!;

    public string AttendingNotes { get; set; } = null!;

    public bool IsSummary { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public bool? IsInformConcern { get; set; }

    public byte[]? BodyImage { get; set; }

    public bool? Imported { get; set; }

    public DateTime? ImportedDateTime { get; set; }

    public string? ToRegistrationInfoMedicID { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
