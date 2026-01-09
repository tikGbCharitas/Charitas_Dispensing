using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionItemTempPaymentReturn
{
    public string Prescription { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string IntermBillNo { get; set; } = null!;

    public string PaymentNo { get; set; } = null!;

    public decimal? Price { get; set; }

    public decimal? Discount { get; set; }

    public decimal? LineAmount { get; set; }
}
