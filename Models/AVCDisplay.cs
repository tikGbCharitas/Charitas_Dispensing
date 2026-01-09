using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AVCDisplay
{
    public int? DisplayID { get; set; }

    public int? CounterID { get; set; }

    public int? SortCounter { get; set; }

    public string? CounterShowType { get; set; }

    public bool? CounterSound { get; set; }

    public string? Notes { get; set; }
}
