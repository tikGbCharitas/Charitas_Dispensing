using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CssdItemDetail
{
    public string ItemID { get; set; } = null!;

    public string ItemDetailID { get; set; } = null!;

    public decimal Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
