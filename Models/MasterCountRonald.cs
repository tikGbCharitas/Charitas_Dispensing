using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MasterCountRonald
{
    public string? name { get; set; }

    public int? number { get; set; }

    public string? type { get; set; }

    public int? low { get; set; }

    public int? high { get; set; }

    public bool? status { get; set; }
}
