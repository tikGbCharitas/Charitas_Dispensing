using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Cencu
{
    public decimal CencusNo { get; set; }

    public DateTime? CencusDate { get; set; }

    public string? CencusTime { get; set; }

    public string? RegistrationNo { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? RoomId { get; set; }

    public string? ClassId { get; set; }

    public string? BedID { get; set; }

    public string? CencusStatus { get; set; }

    public int? PatientBalance { get; set; }

    public int? PatientIn { get; set; }

    public int? PatientTransferOut { get; set; }

    public int? PatientTransferIn { get; set; }

    public int? PatientOut { get; set; }

    public int? PatientDeadInLess48 { get; set; }

    public int? PatientDeadInMore48 { get; set; }

    public string? TypeTransfer { get; set; }

    public string? ServiceUnitIDInfo { get; set; }

    public string? RoomIdInfo { get; set; }

    public string? ClassIdInfo { get; set; }

    public string? BedIDInfo { get; set; }
}
