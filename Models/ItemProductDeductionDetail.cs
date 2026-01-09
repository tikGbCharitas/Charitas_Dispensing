using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductDeductionDetail
{
    public string DeductionID { get; set; } = null!;

    public decimal MinAmount { get; set; }

    public decimal MaxAmount { get; set; }

    public decimal DeductionAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
