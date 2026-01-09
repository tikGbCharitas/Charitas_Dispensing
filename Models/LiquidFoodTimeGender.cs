using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class LiquidFoodTimeGender
{
    public string StandardReferenceID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public string? ChildrenFoodID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
