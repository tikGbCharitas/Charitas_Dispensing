using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class tmp_ron_payment_gdbaru
{
    public string? PaymentNo { get; set; }

    public string? Notes { get; set; }

    public string? RegistrationNo { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? Createdby { get; set; }

    public string? GuarantorID { get; set; }

    public string? TransactionCode { get; set; }

    public string? PaymentReferenceNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? PaymentMethod { get; set; }

    public decimal? PaymentAmount { get; set; }

    public DateTime? StampTime { get; set; }
}
