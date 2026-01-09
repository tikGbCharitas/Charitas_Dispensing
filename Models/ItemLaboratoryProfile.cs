using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemLaboratoryProfile
{
    public string ParentItemID { get; set; } = null!;

    public string DetailItemID { get; set; } = null!;

    public int? DisplaySequence { get; set; }

    public bool? IsDisplayInResult { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
