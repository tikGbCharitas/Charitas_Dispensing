using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTariffRequestItemComp
{
    public string TariffRequestNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public decimal Price { get; set; }

    /// <summary>
    /// Bisa di set True bila di master itemnya IsAllowDiscount=1
    /// </summary>
    public bool IsAllowDiscount { get; set; }

    public bool IsAllowVariable { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
