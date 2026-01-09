using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class JournalGroupDetail
{
    public int JournalDetailID { get; set; }

    public int JournalGroupID { get; set; }

    public string JournalJournalCode { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
