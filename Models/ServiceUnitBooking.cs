using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitBooking
{
    public string BookingNo { get; set; } = null!;

    public DateTime BookingDateTimeFrom { get; set; }

    public DateTime BookingDateTimeTo { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string RoomID { get; set; } = null!;

    public string? PatientID { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public bool IsApproved { get; set; }

    public bool IsVoid { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateByUserID { get; set; }

    public string? SRAnestesiPlan { get; set; }

    public string? ParamedicID2 { get; set; }

    public string? ParamedicID3 { get; set; }

    public string? ParamedicID4 { get; set; }

    public string? ParamedicIDAnestesi { get; set; }

    public string? AssistantID1 { get; set; }

    public string? AssistantID2 { get; set; }

    public string? AssistantID3 { get; set; }

    public string? AssistantID4 { get; set; }

    public string? AssistantIDAnestesi { get; set; }

    public string? Diagnose { get; set; }

    public string? OperationType { get; set; }

    public bool? IsCito { get; set; }

    public string? ProcedureChargeClassID { get; set; }

    public string? OperatingNotes { get; set; }

    public string? Instrumentator1 { get; set; }

    public string? Instrumentator2 { get; set; }

    public string? SRProcedureCategory { get; set; }

    public DateTime? RealizationDateTimeFrom { get; set; }

    public DateTime? RealizationDateTimeTo { get; set; }

    public string? Resident { get; set; }

    public string? AssistantIDInstrumentator { get; set; }

    public string? SmfID { get; set; }

    public bool? IsExtendedSurgery { get; set; }

    public string? SRIndication { get; set; }

    public bool? IsNeedPa { get; set; }

    public byte[]? SRAsaScore { get; set; }

    public string? AssistantID5 { get; set; }

    public string? AssistantIDInstrumentator2 { get; set; }

    public string? AssistantIDInstrumentator3 { get; set; }

    public string? AssistantIDInstrumentator4 { get; set; }

    public string? AssistantIDInstrumentator5 { get; set; }

    public string? Instrumentator3 { get; set; }

    public string? Instrumentator4 { get; set; }

    public string? Instrumentator5 { get; set; }

    public string? AnestesyNotes { get; set; }

    public string? ProcedureID { get; set; }

    public virtual Paramedic Paramedic { get; set; } = null!;

    public virtual ServiceRoom Room { get; set; } = null!;

    public virtual ServiceUnit ServiceUnit { get; set; } = null!;
}
