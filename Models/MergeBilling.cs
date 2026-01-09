using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MergeBilling
{
    public string RegistrationNo { get; set; } = null!;

    public string FromRegistrationNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
