using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SatuSehatLocation
{
    public string LocationID { get; set; } = null!;

    public string LocationName { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string OrganizationID { get; set; } = null!;

    public string? JsonData { get; set; }
}
