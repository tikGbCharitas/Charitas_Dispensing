using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AskesCovered
{
    public string RegistrationNo { get; set; } = null!;

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

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
