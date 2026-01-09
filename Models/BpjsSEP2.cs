using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BpjsSEP2
{
    public string? NoSEP { get; set; }

    public string? NomorKartu { get; set; }

    public DateTime? TanggalSEP { get; set; }

    public DateTime? TanggalRujukan { get; set; }

    public string? NoRujukan { get; set; }

    public string? PPKRujukan { get; set; }

    public string? NamaPPKRujukan { get; set; }

    public string? PPKPelayanan { get; set; }

    public string? JenisPelayanan { get; set; }

    public string? Catatan { get; set; }

    public string? DiagnosaAwal { get; set; }

    public string? PoliTujuan { get; set; }

    public string? KelasRawat { get; set; }

    public string? LakaLantas { get; set; }

    public string? User { get; set; }

    public string? NoMR { get; set; }

    public DateTime? TanggalPulang { get; set; }

    public string? NoTransaksi { get; set; }

    public string? NamaPasien { get; set; }

    public string? NIK { get; set; }

    public string? JenisKelamin { get; set; }

    public DateTime? TanggalLahir { get; set; }

    public string? JenisPeserta { get; set; }

    public string? DetailKeanggotaan { get; set; }

    public string? PatientID { get; set; }

    public string? KodeCBG { get; set; }

    public decimal? TariffCBG { get; set; }

    public string? DeskripsiCBG { get; set; }

    public string? LokasiLaka { get; set; }

    public string? NamaKelasRawat { get; set; }

    public long SepID { get; set; }

    public bool? IsEksekutif { get; set; }

    public bool? IsCob { get; set; }

    public string? PenjaminLaka { get; set; }

    public string? NamaCob { get; set; }

    public string? StatusPeserta { get; set; }

    public string? Umur { get; set; }

    public string? JenisRujukan { get; set; }

    public bool? IsKatarak { get; set; }

    public DateTime? TglKejadian { get; set; }

    public bool? IsSuplesi { get; set; }

    public string? NoSepSuplesi { get; set; }

    public string? KodePropinsi { get; set; }

    public string? KodeKabupaten { get; set; }

    public string? KodeKecamatan { get; set; }

    public string? NoSkdp { get; set; }

    public string? KodeDpjp { get; set; }
}
