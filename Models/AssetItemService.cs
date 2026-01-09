using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetItemService
{
    public string ItemID { get; set; } = null!;

    public string AssetID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
