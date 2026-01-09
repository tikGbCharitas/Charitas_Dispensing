using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetDepreciationPostView
{
    public int AssetDepreciationPostId { get; set; }

    public string AssetGroupId { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public string AssetID { get; set; } = null!;

    public string AssetName { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public int PeriodNo { get; set; }

    public string Year { get; set; } = null!;

    public string Month { get; set; } = null!;

    public decimal DepreciationAmount { get; set; }

    public bool IsPosted { get; set; }

    public int? JournalId { get; set; }

    public int AssetAccumulationAccountId { get; set; }

    public int AssetAccumulationSubLedgerId { get; set; }

    public int AssetCostAccountId { get; set; }

    public int AssetCostSubLedgerId { get; set; }
}
