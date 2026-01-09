using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationInfo
{
    public string RegistrationInfoID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string? Information { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
