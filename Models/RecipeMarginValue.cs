using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RecipeMarginValue
{
    public int CounterID { get; set; }

    public decimal StartingValue { get; set; }

    public decimal EndingValue { get; set; }

    public decimal RecipeAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
