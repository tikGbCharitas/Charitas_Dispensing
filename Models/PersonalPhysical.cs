using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalPhysical
{
    public int PersonalPhysicalID { get; set; }

    public int PersonID { get; set; }

    public string SRPhysicalCharacteristic { get; set; } = null!;

    public string PhysicalValue { get; set; } = null!;

    public string? SRMeasurementCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
