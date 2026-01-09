using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionPhysical
{
    public int PositionPhysicalID { get; set; }

    public int PositionID { get; set; }

    public string? SRPhysicalCharacteristic { get; set; }

    public string? SROperandType { get; set; }

    public string? PhysicalValue { get; set; }

    public string? SRMeasurementCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
