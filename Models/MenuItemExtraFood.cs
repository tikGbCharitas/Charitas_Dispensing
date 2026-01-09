using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MenuItemExtraFood
{
    public string SeqNo { get; set; } = null!;

    public string SRDayName { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public string? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
