using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PaymentMethod
{
    public string SRPaymentTypeID { get; set; } = null!;

    public string SRPaymentMethodID { get; set; } = null!;

    public string PaymentMethodName { get; set; } = null!;

    public int? ChartOfAccountID { get; set; }

    public int? SubledgerID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
