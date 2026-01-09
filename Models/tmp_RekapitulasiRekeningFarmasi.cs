using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class tmp_RekapitulasiRekeningFarmasi
{
    public DateTime? PrescriptionDate { get; set; }

    public string? RegistrationNo { get; set; }

    public string? PatientID { get; set; }

    public string? PrescriptionNo { get; set; }

    public decimal? Potongan { get; set; }

    public decimal? Jual { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? Shift { get; set; }

    public string? Penjamin { get; set; }

    public string? GroupType { get; set; }

    public string? GuarantorType { get; set; }

    public string? GuarantorName { get; set; }

    public decimal? PA { get; set; }

    public decimal? GA { get; set; }

    public string? username { get; set; }

    public string? batal { get; set; }

    public string? aproval { get; set; }

    public string? UserID { get; set; }

    public DateTime? Stime { get; set; }
}
