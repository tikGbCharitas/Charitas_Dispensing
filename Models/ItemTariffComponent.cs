using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTariffComponent
{
    public string SRTariffType { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public string TariffComponentID { get; set; } = null!;

    public decimal Price { get; set; }

    /// <summary>
    /// Bisa di set True bila di master itemnya IsAllowDiscount=1
    /// </summary>
    public bool IsAllowDiscount { get; set; }

    public bool IsAllowVariable { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
