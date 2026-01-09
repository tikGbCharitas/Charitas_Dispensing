using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SupplierFabric
{
    public string FabricID { get; set; } = null!;

    public string SupplierID { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual Fabric Fabric { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
