using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetStatusHistory
{
    public int SeqNo { get; set; }

    public string AssetID { get; set; } = null!;

    public string SRAssetsStatusFrom { get; set; } = null!;

    public string SRAssetsStatusTo { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
