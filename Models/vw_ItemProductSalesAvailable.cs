using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_ItemProductSalesAvailable
{
    public string ItemID { get; set; } = null!;

    public bool? IsSalesAvailable { get; set; }
}
