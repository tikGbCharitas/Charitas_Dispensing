using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class InvoiceSupplier
{
    public string InvoiceNo { get; set; } = null!;

    public string? InvoiceSuppNo { get; set; }

    public string? SupplierID { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? InvoiceDueDate { get; set; }

    public decimal? InvoiceTOP { get; set; }

    public string? InvoiceNotes { get; set; }

    public string? SRPayableStatus { get; set; }

    public string? VoucherID { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRInvoicePayment { get; set; }

    public string? BankID { get; set; }

    public string? BankAccountNo { get; set; }

    public DateTime? VerifyDate { get; set; }

    public string? VerifyByUserID { get; set; }

    public bool? IsInvoicePayment { get; set; }

    public string? InvoiceReferenceNo { get; set; }

    public bool? IsPaymentApproved { get; set; }

    public DateTime? PaymentApprovedDateTime { get; set; }

    public string? PaymentApprovedByUserID { get; set; }

    public bool? IsConsignment { get; set; }

    public bool IsWriteOff { get; set; }

    public string? Reason { get; set; }

    public bool? IsAddPayment { get; set; }

    public DateTime? InvoiceReceivedDate { get; set; }

    public int? CashTransactionReconcileId { get; set; }

    public DateTime? InvoicePaymentPlanDate { get; set; }
}
