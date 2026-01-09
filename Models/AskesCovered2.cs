using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AskesCovered2
{
    public string RegistrationNo { get; set; } = null!;

    public string SeqNo { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal? RoomAmount { get; set; }

    public int? RoomDays { get; set; }

    public decimal? IccuAmount { get; set; }

    public int? IccuDays { get; set; }

    public decimal? HcuAmount { get; set; }

    public int? HcuDays { get; set; }

    public decimal? SurgeryAmount { get; set; }

    public decimal? MedicalSupportAmount { get; set; }

    public decimal? HaemodialiseAmount { get; set; }

    public decimal? CtScanAmount { get; set; }

    public bool IsLock { get; set; }

    public bool IsPaid { get; set; }

    public string? PaymentNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }
}
