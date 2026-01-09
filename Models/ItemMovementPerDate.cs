using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemMovementPerDate
{
    public DateTime MovementDate { get; set; }

    public string LocationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
