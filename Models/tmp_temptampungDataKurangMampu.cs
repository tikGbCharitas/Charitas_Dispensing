using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class tmp_temptampungDataKurangMampu
{
    public string? RegistrationNo { get; set; }

    public string? PatientID { get; set; }

    public string? GuarantorID { get; set; }

    public decimal? Kartu { get; set; }

    public decimal? DiskonKartu { get; set; }

    public decimal? Registrasi { get; set; }

    public decimal? DiskonRegistrasi { get; set; }

    public decimal? Poli { get; set; }

    public decimal? DiskonPoli { get; set; }

    public decimal? Obat { get; set; }

    public decimal? DiskonObat { get; set; }

    public decimal? Penunjang { get; set; }

    public decimal? DiskonPenunjang { get; set; }

    public decimal? IGD { get; set; }

    public decimal? DiskonIGD { get; set; }

    public decimal? Dokter { get; set; }

    public decimal? DiskonDokter { get; set; }

    public decimal? Adm { get; set; }

    public decimal? DiskonAdm { get; set; }

    public decimal? DiskonGlobal { get; set; }

    public decimal? JmlBayar { get; set; }

    public string? UserID { get; set; }

    public DateTime? TimeStamp { get; set; }
}
