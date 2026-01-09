using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesItemFilmConsumption
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string SRFilmID { get; set; } = null!;

    public decimal Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? Kv { get; set; }

    public decimal? Ma { get; set; }

    public decimal? S { get; set; }

    public decimal? Mas { get; set; }
}
