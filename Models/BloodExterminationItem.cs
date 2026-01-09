using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BloodExterminationItem
{
    public string TransactionNo { get; set; } = null!;

    public string BagNo { get; set; } = null!;

    public string? SRBloodGroup { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
