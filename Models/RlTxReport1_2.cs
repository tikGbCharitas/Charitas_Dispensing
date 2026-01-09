using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport1_2
{
    public string RlTxReportNo { get; set; } = null!;

    public int? Bor { get; set; }

    public int? Los { get; set; }

    public int? Bto { get; set; }

    public int? Toi { get; set; }

    public int? Ndr { get; set; }

    public int? Gdr { get; set; }

    public int? RataKunjungan { get; set; }

    public int? RataRata { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
