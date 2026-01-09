using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SupplierLocation
{
    public string SupplierID { get; set; } = null!;

    public string LocationID { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
