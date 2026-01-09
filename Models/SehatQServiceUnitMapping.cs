using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SehatQServiceUnitMapping
{
    public string ServiceUnitID { get; set; } = null!;

    public string? ServiceUnitName { get; set; }

    public string? SQServiceUnitID { get; set; }

    public string? SRRegistrationType { get; set; }
}
