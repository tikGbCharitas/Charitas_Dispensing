using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemGroup
{
    public string ItemGroupID { get; set; } = null!;

    public string ItemGroupName { get; set; } = null!;

    public string? SRItemType { get; set; }

    public decimal CitoValue { get; set; }

    public bool? IsCitoInPercent { get; set; }

    public string? AccountID { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
