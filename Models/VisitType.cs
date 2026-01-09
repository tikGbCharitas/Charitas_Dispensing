using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class VisitType
{
    public string VisitTypeID { get; set; } = null!;

    public string VisitTypeName { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
