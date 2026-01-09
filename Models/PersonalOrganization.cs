using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalOrganization
{
    public int PersonalOrganizationID { get; set; }

    public int PersonID { get; set; }

    public string OrganizationName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string SROrganizationType { get; set; } = null!;

    public string SROrganizationRole { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
