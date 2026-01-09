using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MealOrderDateInit
{
    public DateTime MealOrderDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
