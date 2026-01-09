using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Invoice
{
    public string InvoiceNo { get; set; } = null!;

    public string? SRReceivableType { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? InvoiceDueDate { get; set; }

    public decimal? InvoiceTOP { get; set; }

    public string? GuarantorID { get; set; }

    public string? SRInvoicePayment { get; set; }

    public string? BankID { get; set; }

    public string? BankAccountNo { get; set; }

    public string? InvoiceNotes { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? SRReceivableStatus { get; set; }

    public string? VoucherID { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? VerifyDate { get; set; }

    public string? VerifyByUserID { get; set; }

    public string? PaymentByUserID { get; set; }

    public DateTime? AgingDate { get; set; }

    public bool? IsPaymentApproved { get; set; }

    public DateTime? PaymentApprovedDate { get; set; }

    public string? PaymentApprovedByUserID { get; set; }

    public string? SRPaymentType { get; set; }

    public string? SRPaymentMethod { get; set; }

    public string? SRCardProvider { get; set; }

    public string? SRCardType { get; set; }

    public string? SRDiscountReason { get; set; }

    public string? EDCMachineID { get; set; }

    public string? CardHolderName { get; set; }

    public decimal? CardFeeAmount { get; set; }

    public bool? IsInvoicePayment { get; set; }

    public string? InvoiceReferenceNo { get; set; }

    public string? Reason { get; set; }

    public bool IsWriteOff { get; set; }

    public string? PrintReceiptAsName { get; set; }

    public bool? IsAddPayment { get; set; }

    public bool? IsDiscountInPercantege { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? DiscountAmount { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? TransferNumber { get; set; }

    public bool? IsAdditionalInvoice { get; set; }

    public int? CashTransactionReconcileId { get; set; }

    public DateTime? StartPeriod { get; set; }

    public DateTime? EndPeriod { get; set; }

    public string? SRPhysicianFeeProportionalStatus { get; set; }

    public int? PhysicianFeeProportionalPercentage { get; set; }

    public string? PhysicianFeeProportionalErrMessage { get; set; }
}
