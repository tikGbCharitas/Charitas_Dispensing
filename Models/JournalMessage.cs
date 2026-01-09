using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class JournalMessage
{
    public int JournalID { get; set; }

    public string? Message { get; set; }

    public string? AdditionalData { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public virtual JournalTransaction Journal { get; set; } = null!;
}
