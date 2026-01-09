using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class VitalSignEwsLevel
{
    public string VitalSignID { get; set; } = null!;

    public int StartAgeInDay { get; set; }

    public decimal StartValue { get; set; }

    public int EwsLevel { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
