using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetBook
{
    public string AssetBookID { get; set; } = null!;

    public string AssetBookName { get; set; } = null!;

    public string DepreciationMethodID { get; set; } = null!;

    public string? SRAssetType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual AssetDepreciationMethod DepreciationMethod { get; set; } = null!;
}
