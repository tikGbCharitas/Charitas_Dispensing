using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Notification
{
    public string NotificationID { get; set; } = null!;

    public string? NotificationType { get; set; }

    public string? floor { get; set; }

    public string? type { get; set; }

    public string? UserID { get; set; }

    public bool? IsActive { get; set; }
}
