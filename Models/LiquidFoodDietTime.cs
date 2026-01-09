using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class LiquidFoodDietTime
{
    public string DietID { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public string ChildrenFoodID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
