using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class InvoiceSupplierItem
{
    public string InvoiceNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public DateTime? TransactionDate { get; set; }

    public decimal? VerifyAmount { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string? Notes { get; set; }

    public string? AccountID { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? VoucherID { get; set; }

    public DateTime? AgingDate { get; set; }

    public string? SRInvoicePayment { get; set; }

    public string? BankID { get; set; }

    public string? BankAccountNo { get; set; }

    public DateTime? VerifyDate { get; set; }

    public string? VerifyByUserID { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentByUserID { get; set; }

    public bool? IsPaymentApproved { get; set; }

    public DateTime? PaymentApprovedDate { get; set; }

    public string? PaymentApprovedByUserID { get; set; }

    public decimal? PPnAmount { get; set; }

    public decimal? PPh22Amount { get; set; }

    public decimal? PPh23Amount { get; set; }

    public string? CurrencyID { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal? StampAmount { get; set; }

    public string? InvoiceReferenceNo { get; set; }

    public string? InvoiceSN { get; set; }

    public DateTime? TaxInvoiceDate { get; set; }

    public decimal? OtherDeduction { get; set; }

    public bool? IsAdditionalInvoice { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubLedgerId { get; set; }

    public decimal? DownPaymentAmount { get; set; }

    public string? SRPph { get; set; }

    public decimal? PphPercentage { get; set; }

    public decimal? PphAmount { get; set; }

    public bool? IsPpnExcluded { get; set; }

    public string? SRItemType { get; set; }
}
