using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemStockOpnameApproval
{
    public string TransactionNo { get; set; } = null!;

    public int PageNo { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserID { get; set; }
}
