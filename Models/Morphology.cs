using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Morphology
{
    public string MorphologyID { get; set; } = null!;

    public string? DiagnoseID { get; set; }

    public string MorphologyName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
