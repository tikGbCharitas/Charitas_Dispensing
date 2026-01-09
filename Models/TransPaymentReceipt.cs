using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPaymentReceipt
{
    public string PaymentReceiptNo { get; set; } = null!;

    public DateTime PaymentReceiptDate { get; set; }

    public string PaymentReceiptTime { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string PrintReceiptAsName { get; set; } = null!;

    public byte PrintNumber { get; set; }

    public bool? IsPrinted { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserID { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public virtual ICollection<TransPaymentReceiptItem> TransPaymentReceiptItems { get; set; } = new List<TransPaymentReceiptItem>();
}
