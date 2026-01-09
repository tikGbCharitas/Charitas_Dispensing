using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class InhealthSJP
{
    public string nosjp { get; set; } = null!;

    public string nokainhealth { get; set; } = null!;

    public DateTime tanggalpelayanan { get; set; }

    public DateTime? tanggalasalrujukan { get; set; }

    public string? nomorasalrujukan { get; set; }

    public string? kodeproviderasalrujukan { get; set; }

    public string? NamaProviderAsalRujukan { get; set; }

    public string kodeprovider { get; set; } = null!;

    public string jenispelayanan { get; set; } = null!;

    public string? informasitambahan { get; set; }

    public string? kodediagnosautama { get; set; }

    public string? kodediagnosatambahan { get; set; }

    public string poli { get; set; } = null!;

    public string kelasrawat { get; set; } = null!;

    public int kecelakaankerja { get; set; }

    public string username { get; set; } = null!;

    public string? nomormedicalreport { get; set; }

    public DateTime? TanggalPulang { get; set; }

    public string? NoTransaksi { get; set; }

    public string? DetailKeanggotaan { get; set; }

    public string? PatientID { get; set; }

    public string? kodejenpelruangrawat { get; set; }

    public string NamaPasien { get; set; } = null!;

    public DateTime TanggalLahir { get; set; }

    public string? NoKartuBpjs { get; set; }

    public string? NamaProduk { get; set; }

    public string? KelasRawatPeserta { get; set; }

    public string? BadanUsaha { get; set; }

    public string? ProdukCob { get; set; }

    public string? idsjp { get; set; }
}
