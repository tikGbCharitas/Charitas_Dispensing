using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport4ASebab
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? L0006h { get; set; }

    public int? P0006h { get; set; }

    public int? L0628h { get; set; }

    public int? P0628h { get; set; }

    public int? L28h01t { get; set; }

    public int? P28h01t { get; set; }

    public int? L0104t { get; set; }

    public int? P0104t { get; set; }

    public int? L0414t { get; set; }

    public int? P0414t { get; set; }

    public int? L1424t { get; set; }

    public int? P1424t { get; set; }

    public int? L2444t { get; set; }

    public int? P2444t { get; set; }

    public int? L4464t { get; set; }

    public int? P4464t { get; set; }

    public int? L64t { get; set; }

    public int? P64t { get; set; }

    public int? TotalL { get; set; }

    public int? TotalP { get; set; }

    public int? Total { get; set; }

    public int? TotalMati { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
