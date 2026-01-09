using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppUserUserGroup_bk
{
    public string UserID { get; set; } = null!;

    public string UserGroupID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
