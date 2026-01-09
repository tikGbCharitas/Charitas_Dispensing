using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationPlafondHistory
{
    public long HistoryID { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string GuarantorID { get; set; } = null!;

    public decimal PlafondAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
