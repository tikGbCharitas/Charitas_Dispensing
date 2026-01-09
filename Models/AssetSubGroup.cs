using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetSubGroup
{
    public string AssetGroupId { get; set; } = null!;

    public string AssetSubGroupId { get; set; } = null!;

    public string AssetSubGroupName { get; set; } = null!;

    public string Initial { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
