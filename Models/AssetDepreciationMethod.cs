using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetDepreciationMethod
{
    public string DepreciationMethodID { get; set; } = null!;

    public string DepreciationMethodName { get; set; } = null!;

    public decimal Factor { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual ICollection<AssetBook> AssetBooks { get; set; } = new List<AssetBook>();
}
