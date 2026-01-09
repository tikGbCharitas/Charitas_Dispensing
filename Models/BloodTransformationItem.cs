using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BloodTransformationItem
{
    public string TransactionNo { get; set; } = null!;

    public string BagNo { get; set; } = null!;

    public string SRBloodGroupFrom { get; set; } = null!;

    public string SRBloodGroupTo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
