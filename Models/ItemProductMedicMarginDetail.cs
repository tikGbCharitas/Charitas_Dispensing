using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductMedicMarginDetail
{
    public string ItemID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public decimal AmountPercentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
