using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class JournalGroup
{
    public int JournalGroupID { get; set; }

    public string JournalGroupName { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
