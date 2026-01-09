using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemBalanceExpire
{
    public string LocationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public DateTime ExpiredDate { get; set; }

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
