using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionPersonal
{
    public int PositionPersonalID { get; set; }

    public int PositionID { get; set; }

    public int? MinimumAge { get; set; }

    public int? MaxsimumAge { get; set; }

    public string? SRMaritalStatus { get; set; }

    public string? SRGenderType { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
