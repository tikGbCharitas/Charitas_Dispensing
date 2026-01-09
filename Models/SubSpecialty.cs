using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SubSpecialty
{
    public string SubSpecialtyID { get; set; } = null!;

    public string SRSpecialty { get; set; } = null!;

    public string SubSpecialtyName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
