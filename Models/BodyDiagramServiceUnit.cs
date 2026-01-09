using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BodyDiagramServiceUnit
{
    public string BodyID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
