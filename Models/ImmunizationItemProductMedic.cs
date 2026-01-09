using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ImmunizationItemProductMedic
{
    public string ImmunizationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
