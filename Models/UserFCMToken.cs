using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class UserFCMToken
{
    public int UserFCMTokenID { get; set; }

    public string UserID { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public string FCMToken { get; set; } = null!;

    public string DeviceType { get; set; } = null!;

    public TimeOnly? LastCreatedDateTime { get; set; }
}
