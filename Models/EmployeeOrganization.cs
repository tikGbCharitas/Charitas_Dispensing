using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeOrganization
{
    public int EmployeeOrganizationID { get; set; }

    public int PersonID { get; set; }

    public int OrganizationID { get; set; }

    public int SubOrganizationID { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? ServiceUnitID { get; set; }
}
