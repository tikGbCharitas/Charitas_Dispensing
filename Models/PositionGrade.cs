using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionGrade
{
    public int PositionGradeID { get; set; }

    public string PositionGradeCode { get; set; } = null!;

    public string PositionGradeName { get; set; } = null!;

    public string Interval { get; set; } = null!;

    public short Ranking { get; set; }

    public string? RankName { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
