using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductSalesDiscount
{
    public string SalesDiscID { get; set; } = null!;

    public string SRItemType { get; set; } = null!;

    public decimal SupplierDiscPercentageFrom { get; set; }

    public decimal SupplierDiscPercentageTo { get; set; }

    public decimal SalesDiscPercentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
