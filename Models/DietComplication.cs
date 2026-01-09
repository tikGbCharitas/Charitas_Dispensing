using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DietComplication
{
    public string DietID { get; set; } = null!;

    public string DietComplicationID { get; set; } = null!;

    public bool IsActive { get; set; }
}
