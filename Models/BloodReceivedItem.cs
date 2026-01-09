using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BloodReceivedItem
{
    public string TransactionNo { get; set; } = null!;

    public string BagNo { get; set; } = null!;

    public string SRBloodType { get; set; } = null!;

    public string BloodRhesus { get; set; } = null!;

    public string SRBloodGroup { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
