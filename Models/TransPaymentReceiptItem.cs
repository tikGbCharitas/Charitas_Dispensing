using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPaymentReceiptItem
{
    public string PaymentReceiptNo { get; set; } = null!;

    public string PaymentNo { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public decimal? Amount { get; set; }

    public virtual TransPayment PaymentNoNavigation { get; set; } = null!;

    public virtual TransPaymentReceipt PaymentReceiptNoNavigation { get; set; } = null!;
}
