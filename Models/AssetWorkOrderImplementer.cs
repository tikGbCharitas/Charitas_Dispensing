using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetWorkOrderImplementer
{
    public string OrderNo { get; set; } = null!;

    public string UserID { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
