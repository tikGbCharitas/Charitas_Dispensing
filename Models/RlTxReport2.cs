using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport2
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? KeadaanLakiLaki { get; set; }

    public int? KeadaanPerempuan { get; set; }

    public int? KebutuhanLakiLaki { get; set; }

    public int? KebutuhanPerempuan { get; set; }

    public int? KekuranganLakiLaki { get; set; }

    public int? KekuranganPerempuan { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
