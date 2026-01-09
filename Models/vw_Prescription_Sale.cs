using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_Prescription_Sale
{
    public string? RegistrationNo { get; set; }

    public string? PatientID { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public string? PatientName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? MedicalNo { get; set; }

    public string OldMedicalNo { get; set; } = null!;

    public string? SRItemUnit { get; set; }

    public decimal PrescriptionQty { get; set; }

    public byte FOD { get; set; }

    public string DP { get; set; } = null!;

    public decimal NOD { get; set; }

    public string? Unit { get; set; }

    public string? CodeLabel { get; set; }

    public string? Label { get; set; }

    public string ACPCDC { get; set; } = null!;

    public string? Notes { get; set; }

    public string? ItemName { get; set; }

    public string? NamaJumlah { get; set; }

    public string? NamaJumlahQty { get; set; }

    public string? ParamedicName { get; set; }

    public byte AgeInYear { get; set; }

    public string Jumlah { get; set; } = null!;

    public decimal? Price { get; set; }

    public string IsRFlag { get; set; } = null!;

    public string PrescriptionNo { get; set; } = null!;

    public string? Nomor { get; set; }

    public string ConsumeMethod { get; set; } = null!;

    public string? metod { get; set; }

    public string? APC { get; set; }
}
