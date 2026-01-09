using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeePaymentHd
{
    public string PaymentNo { get; set; } = null!;

    public DateOnly PaymentDate { get; set; }

    public string ParamedicID { get; set; } = null!;

    public string? PaymentMethodID { get; set; }

    public string? BankID { get; set; }

    public string? BankAccountNo { get; set; }

    public decimal? PaymentAmount { get; set; }

    public bool? IsVoid { get; set; }

    public bool IsApproved { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
