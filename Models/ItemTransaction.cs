using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTransaction
{
    public string TransactionNo { get; set; } = null!;

    public string TransactionCode { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string BusinessPartnerID { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public string? CurrencyID { get; set; }

    public decimal? CurrencyRate { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public DateTime ReferenceDate { get; set; }

    public string? FromServiceUnitID { get; set; }

    public string? FromLocationID { get; set; }

    public string? ToServiceUnitID { get; set; }

    public string? ToLocationID { get; set; }

    public string? TermID { get; set; }

    public string SRItemType { get; set; } = null!;

    public decimal DiscountAmount { get; set; }

    public decimal ChargesAmount { get; set; }

    public decimal StampAmount { get; set; }

    public decimal DownPaymentAmount { get; set; }

    public string DownPaymentReferenceNo { get; set; } = null!;

    public string SRDownPaymentType { get; set; } = null!;

    public string SRAdjustmentType { get; set; } = null!;

    public string SRDistributionType { get; set; } = null!;

    public string SRPurchaseReturnType { get; set; } = null!;

    public string? SRPurchaseOrderType { get; set; }

    public decimal TaxPercentage { get; set; }

    public decimal TaxAmount { get; set; }

    public short IsTaxable { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserID { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool IsClosed { get; set; }

    public bool IsBySystem { get; set; }

    public bool? IsNonMasterOrder { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? ProductAccountID { get; set; }

    public string? LeadTime { get; set; }

    public decimal? Pph22 { get; set; }

    public decimal? Pph23 { get; set; }

    public string? ContractNo { get; set; }

    public decimal? PriorChargesAmount { get; set; }

    public decimal? PriorTaxAmount { get; set; }

    public string? CustomerID { get; set; }

    public string? TaxInvoiceNo { get; set; }

    public DateTime? TaxInvoiceDate { get; set; }

    public string? SRPaymentType { get; set; }

    public string? SRPurchaseCategorization { get; set; }

    public bool? IsInventoryItem { get; set; }

    public decimal? TermOfPayment { get; set; }

    public bool? IsAssets { get; set; }

    public int? BudgetPlanCounter { get; set; }

    public string? ServiceUnitCostID { get; set; }

    public bool? IsPph22InPercent { get; set; }

    public decimal? Pph22Percentage { get; set; }

    public bool? IsPph23InPercent { get; set; }

    public decimal? Pph23Percentage { get; set; }

    public bool? IsConsignment { get; set; }

    public decimal? AmountTaxed { get; set; }

    public short? RevisionNumber { get; set; }

    public short? PrintNumber { get; set; }

    public DateTime? LastPrintedDateTime { get; set; }

    public string? LastPrintedByUserID { get; set; }

    public decimal? AdvanceAmount { get; set; }

    public string? DeliveryOrdersNo { get; set; }

    public DateTime? DeliveryOrdersDate { get; set; }

    public decimal? PphAmount { get; set; }

    public DateTime? InvoiceSupplierDate { get; set; }

    public string? CashTransactionReconcileId { get; set; }
}
