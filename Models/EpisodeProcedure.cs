using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EpisodeProcedure
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public DateTime ProcedureDate { get; set; }

    public string ProcedureTime { get; set; } = null!;

    public DateTime ProcedureDate2 { get; set; }

    public string ProcedureTime2 { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string ParamedicID2 { get; set; } = null!;

    public string ProcedureID { get; set; } = null!;

    public string SRProcedureCategory { get; set; } = null!;

    public string SRAnestesi { get; set; } = null!;

    public string RoomID { get; set; } = null!;

    public bool IsCito { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? AssistantID1 { get; set; }

    public string? AssistantID2 { get; set; }

    public string? Notes { get; set; }

    public string? BookingNo { get; set; }

    public string? ParamedicID2a { get; set; }

    public string? ParamedicID3a { get; set; }

    public string? ParamedicID4a { get; set; }

    public string? ParamedicIDAnestesi { get; set; }

    public string? AssistantIDAnestesi { get; set; }

    public string? InstrumentatorID1 { get; set; }

    public string? InstrumentatorID2 { get; set; }

    public bool? IsFromOperatingRoom { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? AnestesyNotes { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
