using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesItemCompTempPaymentReturn
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public string IntermBillNo { get; set; } = null!;

    public string PaymentNo { get; set; } = null!;

    public decimal? Price { get; set; }

    public decimal? Discount { get; set; }
}
