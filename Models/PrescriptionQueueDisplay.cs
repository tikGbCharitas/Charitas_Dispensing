using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PrescriptionQueueDisplay
{
    public string? IP { get; set; }

    public string? ServiceUnitID { get; set; }

    public bool? IsComplete { get; set; }

    public int? CurrentPage { get; set; }
}
