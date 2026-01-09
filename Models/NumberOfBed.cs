using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NumberOfBed
{
    public DateTime StartingDate { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public int NumberOfBed1 { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
