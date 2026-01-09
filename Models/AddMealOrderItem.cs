using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AddMealOrderItem
{
    public string OrderNo { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
