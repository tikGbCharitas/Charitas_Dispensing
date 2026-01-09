using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport3_14
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? RujukanPuskesmas { get; set; }

    public int? RujukanFasKesLain { get; set; }

    public int? RujukanRsLain { get; set; }

    public int? DirujukKePuskesmasAsal { get; set; }

    public int? DirujukKeFasKesAsal { get; set; }

    public int? DirujukKeRsAsal { get; set; }

    public int? DirujukPasienRujukan { get; set; }

    public int? DirujukPasienDtgSendiri { get; set; }

    public int? DirujukDiterimaKembali { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
