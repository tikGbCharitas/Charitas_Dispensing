using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppUserGroup
{
    public string UserGroupID { get; set; } = null!;

    public string UserGroupName { get; set; } = null!;

    public bool IsEditAble { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
