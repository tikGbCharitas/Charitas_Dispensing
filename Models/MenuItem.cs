using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MenuItem
{
    public string MenuItemID { get; set; } = null!;

    public string MenuItemName { get; set; } = null!;

    public string MenuID { get; set; } = null!;

    public string VersionID { get; set; } = null!;

    public string SeqNo { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
