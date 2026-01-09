using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppMessage
{
    public string MessageID { get; set; } = null!;

    public string MessageText { get; set; } = null!;

    public string? MessageTextCustom { get; set; }

    public bool? IsError { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
