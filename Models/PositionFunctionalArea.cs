using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionFunctionalArea
{
    public int PositionFunctionalAreaID { get; set; }

    public int PositionID { get; set; }

    public string SRPositionFunctionalArea { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
