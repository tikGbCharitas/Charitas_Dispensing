using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPaymentPatientItem
{
    public string PaymentNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string SRPaymentType { get; set; } = null!;

    public string SRPaymentMethod { get; set; } = null!;

    public string? SRCardProvider { get; set; }

    public string? SRCardType { get; set; }

    public string? EDCMachineID { get; set; }

    public string? CardHolderName { get; set; }

    public decimal? CardFeeAmount { get; set; }

    public string? BankID { get; set; }

    public decimal Amount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? CardNo { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceSequenceNo { get; set; }
}
