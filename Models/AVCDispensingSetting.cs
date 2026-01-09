using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AVCDispensingSetting
{
    public string UserID { get; set; } = null!;

    public string? Language { get; set; }

    public string? Theme { get; set; }

    public DateTime LastUpdatebyTime { get; set; }
}
