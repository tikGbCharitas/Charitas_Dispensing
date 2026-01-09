using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CensusBalance
{
    public DateTime CensusDate { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string SmfID { get; set; } = null!;

    public int? Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? NumberOfBed { get; set; }
}
