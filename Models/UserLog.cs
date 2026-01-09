using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class UserLog
{
    public long UserLogID { get; set; }

    public string? ApplicationID { get; set; }

    public string SessionID { get; set; } = null!;

    public string? UserID { get; set; }

    public DateTime? LoginDateTime { get; set; }

    public string? ClientIP { get; set; }

    public string? BrowserInfo { get; set; }

    public DateTime? LogoutDateTime { get; set; }
}
