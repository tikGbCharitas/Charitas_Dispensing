using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MealOrderItemPlan
{
    public string OrderNo { get; set; } = null!;

    public DateTime? OrderToDate { get; set; }

    public string SRMealSet { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
