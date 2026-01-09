using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class HL7Message
{
    public Guid MessageID { get; set; }

    public string Message { get; set; } = null!;

    public DateTime MessageDateTime { get; set; }

    public string MessageFileName { get; set; } = null!;
}
