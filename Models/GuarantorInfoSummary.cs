using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorInfoSummary
{
    public string GuarantorID { get; set; } = null!;

    public int? NoteCount { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
