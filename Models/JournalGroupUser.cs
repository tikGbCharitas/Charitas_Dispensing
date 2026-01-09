using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class JournalGroupUser
{
    public int JournalUserID { get; set; }

    public int JournalGroupID { get; set; }

    public string UserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
