using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_ItemServiceAndRadiology
{
    public string ItemID { get; set; } = null!;

    public string ItemGroupID { get; set; } = null!;

    public string SRItemType { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public bool IsActive { get; set; }
}
