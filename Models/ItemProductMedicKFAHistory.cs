using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductMedicKFAHistory
{
    public string ItemID { get; set; } = null!;

    public string KFACode { get; set; } = null!;

    public string NIE_BPOM { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreateByID { get; set; }

    public DateTime? CreateAt { get; set; }

    public string? LastUpdateByID { get; set; }

    public DateTime? LastUpdateAt { get; set; }
}
