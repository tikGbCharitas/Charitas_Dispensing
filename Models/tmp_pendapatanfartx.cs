using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class tmp_pendapatanfartx
{
    public DateTime? TransactionDate { get; set; }

    public string? TransactionNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? IsPrescriptionReturn { get; set; }

    public string? ItemID { get; set; }

    public decimal? LineAmount { get; set; }

    public string? PaymentNo { get; set; }

    public decimal? AmountPayment { get; set; }

    public string? UserPayment { get; set; }

    public string? UserInput { get; set; }

    public string? ToServiceUnitID { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Price { get; set; }

    public string? RegistrationNo { get; set; }

    public decimal? PatientAmount { get; set; }

    public decimal? GuarantorAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? DiscountAmount2 { get; set; }

    public string? aproval { get; set; }

    public string? Shift { get; set; }

    public string? isvoid { get; set; }

    public string? UserID { get; set; }

    public DateTime? Stime { get; set; }

    public string? TransSeqNo { get; set; }
}
