using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MealOrderItem
{
    public string OrderNo { get; set; } = null!;

    public string SRMealSet { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public bool IsOptional { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? RatingFoodID { get; set; }
}
