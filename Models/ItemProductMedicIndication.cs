using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductMedicIndication
{
    public string ItemID { get; set; } = null!;

    public string IndicationID { get; set; } = null!;

    public DateTime? InsertDateTime { get; set; }

    public string? InsertByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
