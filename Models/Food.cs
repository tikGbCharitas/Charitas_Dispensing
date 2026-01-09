using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Food
{
    public string FoodID { get; set; } = null!;

    public string FoodName { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public decimal Weight { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public decimal QtyPortion { get; set; }

    public string SRFoodGroup1 { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
