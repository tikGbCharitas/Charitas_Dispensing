using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorItemTypeRule
{
    public string GuarantorID { get; set; } = null!;

    public string SRItemType { get; set; } = null!;

    public bool IsToGuarantor { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
