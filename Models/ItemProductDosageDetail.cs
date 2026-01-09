using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductDosageDetail
{
    public string ItemID { get; set; } = null!;

    public decimal Dosage { get; set; }

    public string SRDosageUnit { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
