using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MenuSetting
{
    public DateTime StartingDate { get; set; }

    public string VersionID { get; set; } = null!;

    public string SeqNo { get; set; } = null!;

    public bool? IsExtra { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
