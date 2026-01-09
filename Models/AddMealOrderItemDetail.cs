using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AddMealOrderItemDetail
{
    public string OrderNo { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public short? Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
