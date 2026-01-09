using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class InvoiceAdjusment
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string SupplierGuarantor { get; set; } = null!;

    public string Type { get; set; } = null!;

    public decimal Amount { get; set; }

    public string Reason { get; set; } = null!;

    public bool IsApproved { get; set; }

    public string Note { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? InvoicePaymentNo { get; set; }

    public decimal? PaymentAmount { get; set; }

    public decimal? OtherCost { get; set; }

    public decimal? BankCost { get; set; }
}
