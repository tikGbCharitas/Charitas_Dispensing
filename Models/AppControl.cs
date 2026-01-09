using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppControl
{
    public string ControlID { get; set; } = null!;

    public string? ControlType { get; set; }

    public string? Description { get; set; }

    public string? ControlUrl { get; set; }
}
