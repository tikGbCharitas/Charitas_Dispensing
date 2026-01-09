using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SatuSehatOrganization
{
    public string OrganizationID { get; set; } = null!;

    public string OrganizationName { get; set; } = null!;

    public string? DepartementID { get; set; }

    public string? parOf { get; set; }

    public string? JsonData { get; set; }
}
