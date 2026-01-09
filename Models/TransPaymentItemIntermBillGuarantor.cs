using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPaymentItemIntermBillGuarantor
{
    public string PaymentNo { get; set; } = null!;

    public string IntermBillNo { get; set; } = null!;

    public bool IsPaymentProceed { get; set; }

    public bool IsPaymentReturned { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? GuarantorID { get; set; }
}
