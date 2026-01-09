using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorInfo
{
    public string GuarantorInfoID { get; set; } = null!;

    public string GuarantorID { get; set; } = null!;

    public string? Information { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
