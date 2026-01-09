using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OrganizationUnit
{
    public int OrganizationUnitID { get; set; }

    public string OrganizationUnitCode { get; set; } = null!;

    public string OrganizationUnitName { get; set; } = null!;

    public int? ParentOrganizationUnitID { get; set; }

    public string SROrganizationLevel { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
