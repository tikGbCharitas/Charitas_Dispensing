using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetDepreciationPost
{
    public int AssetDepreciationPostId { get; set; }

    public string AssetID { get; set; } = null!;

    public int PeriodNo { get; set; }

    public string Year { get; set; } = null!;

    public string Month { get; set; } = null!;

    public DateTime DepreciationDate { get; set; }

    public decimal CurrentAmount { get; set; }

    public decimal DepreciationAmount { get; set; }

    public decimal AccumulationAmount { get; set; }

    public bool IsPosted { get; set; }

    public int? PostingId { get; set; }

    public DateTime? PostedDate { get; set; }

    public int? JournalId { get; set; }

    public string? JournalNumber { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
