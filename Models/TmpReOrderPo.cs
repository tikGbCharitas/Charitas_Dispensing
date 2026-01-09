using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TmpReOrderPo
{
    public string UserID { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public string SupplierID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal? Quantity { get; set; }
}
