using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport5_4
{
    public string RlTxReportNo { get; set; } = null!;

    public string DiagnosaID { get; set; } = null!;

    public int? KasusBaruL { get; set; }

    public int? KasusBaruP { get; set; }

    public int? JumlahKasusBaru { get; set; }

    public int? JumlahKunjungan { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
