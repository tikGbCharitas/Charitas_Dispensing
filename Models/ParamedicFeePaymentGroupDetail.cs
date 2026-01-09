using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeePaymentGroupDetail
{
    public string PaymentGroupNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public decimal AmountFee4Service { get; set; }

    public decimal AmountAddDec { get; set; }

    public decimal AmountGuarantee { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
