using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport3_13b
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? JumlahItemObat { get; set; }

    public int? JumlahItemObatRs { get; set; }

    public int? JumlahItemObatFormulariumRs { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
