using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductMargin
{
    public string MarginID { get; set; } = null!;

    public string MarginName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual ICollection<ItemProductMarginValue> ItemProductMarginValues { get; set; } = new List<ItemProductMarginValue>();
}
