using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductMedicZatActive
{
    public string ItemID { get; set; } = null!;

    public string ZatActiveID { get; set; } = null!;

    public DateTime? InsertDateTime { get; set; }

    public string? InsertByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsPrinted { get; set; }
}
