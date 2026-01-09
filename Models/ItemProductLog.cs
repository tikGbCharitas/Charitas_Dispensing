using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductLog
{
    public string TariffRequestNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal PriceInPurchaseUnitOld { get; set; }

    public decimal PriceInPurchaseUnitNew { get; set; }

    public decimal PriceInBaseUnitOld { get; set; }

    public decimal PriceInBaseUnitNew { get; set; }

    public decimal PriceInBaseUnitWVatOld { get; set; }

    public decimal PriceInBaseUnitWVatNew { get; set; }

    public decimal CostPriceOld { get; set; }

    public decimal CostPriceNew { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public decimal? SalesDiscountOld { get; set; }

    public decimal? SaledDiscountNew { get; set; }
}
