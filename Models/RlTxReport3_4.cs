using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport3_4
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? RmRumahSakit { get; set; }

    public int? RmBidan { get; set; }

    public int? RmPuskesmas { get; set; }

    public int? RmFasKesLain { get; set; }

    public int? RmHidup { get; set; }

    public int? RmMati { get; set; }

    public int? RmTotal { get; set; }

    public int? RnmHidup { get; set; }

    public int? RnmMati { get; set; }

    public int? RnmTotal { get; set; }

    public int? NrHidup { get; set; }

    public int? NrMati { get; set; }

    public int? NrTotal { get; set; }

    public int? DiRujuk { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
