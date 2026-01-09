using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport5_3
{
    public string RlTxReportNo { get; set; } = null!;

    public string DiagnosaID { get; set; } = null!;

    public int? KeluarHidupL { get; set; }

    public int? KeluarHidupP { get; set; }

    public int? KeluarMatiL { get; set; }

    public int? KeluarMatiP { get; set; }

    public int? Total { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
