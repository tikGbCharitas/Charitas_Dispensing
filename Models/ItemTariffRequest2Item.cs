using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTariffRequest2Item
{
    public string TariffRequestNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal? PriceInBaseUnit { get; set; }

    public decimal? PriceInBaseUnitWVat { get; set; }

    public decimal? PriceInPurchaseUnit { get; set; }

    public decimal? CostPrice { get; set; }

    public bool? IsAllowCito { get; set; }

    public bool? IsCitoInPercent { get; set; }

    public decimal? CitoValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? DiscPercentage { get; set; }
}
