using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionLevel
{
    public int PositionLevelID { get; set; }

    public string PositionLevelCode { get; set; } = null!;

    public string PositionLevelName { get; set; } = null!;

    public short Ranking { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
