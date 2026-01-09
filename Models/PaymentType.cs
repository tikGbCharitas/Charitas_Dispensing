using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PaymentType
{
    public string SRPaymentTypeID { get; set; } = null!;

    public string PaymentTypeName { get; set; } = null!;

    public int? ChartOfAccountID { get; set; }

    public int? SubledgerID { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool isCashierFrontOffice { get; set; }

    public bool? IsArPayment { get; set; }

    public bool? IsApPayment { get; set; }

    public bool? IsFeePayment { get; set; }
}
