using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport12Item
{
    public string PeriodMonth { get; set; } = null!;

    public string PeriodYear { get; set; } = null!;

    public int? HariPerawatan { get; set; }

    public int? LamaDirawat { get; set; }

    public int? Keluar { get; set; }

    public int? KeluarMati48 { get; set; }

    public int? KeluarMati { get; set; }

    public int? Tt { get; set; }

    public int? HariDlmSatuPeriode { get; set; }

    public int? Kunjungan { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
