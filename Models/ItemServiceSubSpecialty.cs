using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemServiceSubSpecialty
{
    public string ItemID { get; set; } = null!;

    public string SubSpecialtyID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
