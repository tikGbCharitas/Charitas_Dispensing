using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTariff
{
    public string SRTariffType { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public decimal Price { get; set; }

    public bool? IsAdminCalculation { get; set; }

    /// <summary>
    /// Setting untuk item yg tarifnya tidak di rinci
    /// </summary>
    public bool? IsAllowDiscount { get; set; }

    /// <summary>
    /// Setting untuk item yg tarifnya tidak di rinci
    /// </summary>
    public bool? IsAllowVariable { get; set; }

    public bool? IsAllowCito { get; set; }

    public bool? IsCitoInPercent { get; set; }

    public decimal? CitoValue { get; set; }

    /// <summary>
    /// Update from TransactionNo
    /// </summary>
    public string? ReferenceNo { get; set; }

    public string? ReferenceTransactionCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public decimal? DiscPercentage { get; set; }

    public bool? IsCitoFromStandardReference { get; set; }
}
