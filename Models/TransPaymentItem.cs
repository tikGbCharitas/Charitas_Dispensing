using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPaymentItem
{
    public string PaymentNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string SRPaymentType { get; set; } = null!;

    public string SRPaymentMethod { get; set; } = null!;

    public string? SRCardProvider { get; set; }

    public string? SRCardType { get; set; }

    public string? SRDiscountReason { get; set; }

    public string? EDCMachineID { get; set; }

    public string? CardHolderName { get; set; }

    public decimal? CardFeeAmount { get; set; }

    public string? BankID { get; set; }

    public string? ReferenceNo { get; set; }

    public decimal Amount { get; set; }

    public decimal Balance { get; set; }

    public bool IsFromDownPayment { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsPackageClosed { get; set; }

    public string? CardNo { get; set; }

    public decimal? RoundingAmount { get; set; }

    public decimal? AmountReceived { get; set; }

    public string? ReferenceSequenceNo { get; set; }

    public int? CashTransactionReconcileId { get; set; }

    public bool? IsBackOfficeReturn { get; set; }

    public int? BackOfficeReturnTransactionId { get; set; }

    public virtual TransPayment PaymentNoNavigation { get; set; } = null!;
}
