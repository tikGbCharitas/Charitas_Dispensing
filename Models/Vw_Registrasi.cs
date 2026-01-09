using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Vw_Registrasi
{
    public string RegistrationNo { get; set; } = null!;

    public string? MedicalNo { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string Diag_Awal { get; set; } = null!;

    public string Identitas { get; set; } = null!;

    public string No_Identitas { get; set; } = null!;

    public string KlasifikasiPasien { get; set; } = null!;

    public string Nm_Kel_Pasien { get; set; } = null!;

    public string Cara_Masuk { get; set; } = null!;

    public string PerujukDari { get; set; } = null!;

    public string Ket_Perujuk { get; set; } = null!;

    public string CaraKeluar { get; set; } = null!;

    public string DirujukKe { get; set; } = null!;

    public string KetDirujuk { get; set; } = null!;

    public string User_ID { get; set; } = null!;

    public string? LastCreateUserID { get; set; }

    public string Nm_PJ { get; set; } = null!;

    public string Alamat_PJ { get; set; } = null!;

    public string Kd_Kecamatan_PJ { get; set; } = null!;

    public string No_Telp_Pj { get; set; } = null!;

    public string Identitas_Pj { get; set; } = null!;

    public string No_Identitas_PJ { get; set; } = null!;

    public string Hub_PJ { get; set; } = null!;

    public string Kd_Layanan { get; set; } = null!;

    public string Kd_Dokter { get; set; } = null!;

    public string TPP { get; set; } = null!;

    public string BadanUsaha { get; set; } = null!;

    public string Hub_Klasifikasi { get; set; } = null!;

    public string KelasTanggungan { get; set; } = null!;

    public string Kd_Kelas_Reg { get; set; } = null!;

    public string Penanggung { get; set; } = null!;

    public string Hub_Penanggung { get; set; } = null!;

    public int? Mati_UGD { get; set; }

    public int? Mati_Sebelum_UGD { get; set; }

    public int? Lebih_15_Jam { get; set; }

    public int? StatusAntrian { get; set; }

    public int? KasusBaru { get; set; }

    public int? TekananDarah { get; set; }

    public int? Nadi { get; set; }

    public int? Suhu { get; set; }

    public int? BeratBadan { get; set; }

    public int? GDS { get; set; }

    public int? EKG { get; set; }

    public int? EKGMonitor { get; set; }

    public int? KKPG { get; set; }

    public int? PGD { get; set; }

    public int? Observasi { get; set; }

    public int? Keterangan { get; set; }

    public int? SebabKecelakaan { get; set; }
}
