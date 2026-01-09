using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetGroup
{
    public string AssetGroupId { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Initial { get; set; }

    public bool IsActive { get; set; }

    public int AssetAccountId { get; set; }

    public int AssetSubLedgerId { get; set; }

    public int AssetAccumulationAccountId { get; set; }

    public int AssetAccumulationSubLedgerId { get; set; }

    public int AssetCostAccountId { get; set; }

    public int AssetCostSubLedgerId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
