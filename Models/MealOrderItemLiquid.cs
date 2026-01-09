using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MealOrderItemLiquid
{
    public string OrderNo { get; set; } = null!;

    public string MealTime { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public string? DietLiquidTransNo { get; set; }

    public bool? IsDistributed { get; set; }

    public bool? IsVoidDistributed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
