using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemPackageTariffComponent
{
    public string ItemID { get; set; } = null!;

    public string DetailItemID { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal? Discount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
