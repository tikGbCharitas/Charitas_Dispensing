using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport3_12
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? KonselingAnc { get; set; }

    public int? KonselingPascaPersalinan { get; set; }

    public int? KbBaruCmBukanRujukan { get; set; }

    public int? KbBaruCmRujukanRi { get; set; }

    public int? KbBaruCmRujukanRj { get; set; }

    public int? KbBaruCmTotal { get; set; }

    public int? KbBaruDkNifas { get; set; }

    public int? KbBaruDkAbortus { get; set; }

    public int? KbBaruDkLain { get; set; }

    public int? KunjunganUlang { get; set; }

    public int? KeluhanEfekSamping { get; set; }

    public int? KeluhanEfekSampingDiRujuk { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
