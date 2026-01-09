using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Position
{
    public int PositionID { get; set; }

    public string PositionCode { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public string Summary { get; set; } = null!;

    public int? PositionGradeID { get; set; }

    public int? PositionLevelID { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
