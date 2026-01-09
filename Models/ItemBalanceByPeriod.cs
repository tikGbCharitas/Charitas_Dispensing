using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemBalanceByPeriod
{
    public string LocationID { get; set; } = null!;

    public int PeriodYear { get; set; }

    public int PeriodMonth { get; set; }

    public string ItemID { get; set; } = null!;

    public decimal BeginningBalance { get; set; }

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public decimal AdjustmentIn { get; set; }

    public decimal AdjustmentOut { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
