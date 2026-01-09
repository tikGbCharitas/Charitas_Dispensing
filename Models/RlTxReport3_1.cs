using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport3_1
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? PasienAwal { get; set; }

    public int? PasienMasuk { get; set; }

    public int? PasienKeluarHidup { get; set; }

    public int? PasienKeluarMatiK48 { get; set; }

    public int? PasienKeluarMatiL48 { get; set; }

    public int? LamaRawat { get; set; }

    public int? PasienAkhir { get; set; }

    public int? HariRawat { get; set; }

    public int? Vvip { get; set; }

    public int? Vip { get; set; }

    public int? I { get; set; }

    public int? Ii { get; set; }

    public int? Iii { get; set; }

    public int? KelasKhusus { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
