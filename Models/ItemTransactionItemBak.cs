using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTransactionItemBak
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ReferenceNo { get; set; } = null!;

    public string ReferenceSequenceNo { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public decimal QuantityFinishInBaseUnit { get; set; }

    public int? PageNo { get; set; }

    public decimal CostPrice { get; set; }

    public decimal Price { get; set; }

    public decimal PriceInCurrency { get; set; }

    public decimal Discount1Percentage { get; set; }

    public decimal Discount2Percentage { get; set; }

    public string BatchNumber { get; set; } = null!;

    public DateTime? ExpiredDate { get; set; }

    public bool IsPackage { get; set; }

    public bool IsBonusItem { get; set; }

    public bool IsClosed { get; set; }

    public string? Description { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public decimal? RequestQty { get; set; }

    public decimal? Discount { get; set; }

    public decimal? DiscountInCurrency { get; set; }

    public bool? IsDiscountInPercent { get; set; }

    public bool? IsInvoiceUpdate { get; set; }

    public decimal? PriorPrice { get; set; }

    public decimal? PriorPriceInCurrency { get; set; }

    public decimal? PriorDiscount1Percentage { get; set; }

    public decimal? PriorDiscount2Percentage { get; set; }

    public decimal? PriorDiscount { get; set; }

    public decimal? PriorDiscountInCurrency { get; set; }

    public DateTime? LastInvoiceUpdateDateTime { get; set; }

    public string? LastInvoiceUpdateByUserID { get; set; }

    public decimal? HistoryPrice { get; set; }

    public decimal? HistoryPriceInCurrency { get; set; }

    public decimal? HistoryDiscount1Percentage { get; set; }

    public decimal? HistoryDiscount2Percentage { get; set; }

    public decimal? HistoryDiscount { get; set; }

    public decimal? HistoryDiscountInCurrency { get; set; }

    public string? Specification { get; set; }
}
