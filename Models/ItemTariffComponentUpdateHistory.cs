using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTariffComponentUpdateHistory
{
    public string RequestNo { get; set; } = null!;

    public string SRTariffType { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public string TariffComponentID { get; set; } = null!;

    public decimal? Price { get; set; }

    public decimal? ToPrice { get; set; }

    public bool? IsAllowDiscount { get; set; }

    public bool? ToIsAllowDiscount { get; set; }

    public bool? IsAllowVariable { get; set; }

    public bool? ToIsAllowVariable { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
