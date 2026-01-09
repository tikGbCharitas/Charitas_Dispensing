using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class LiquidFoodDietTimeGender
{
    public string DietID { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public string ChildrenFoodID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
