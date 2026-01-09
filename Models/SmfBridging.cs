using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SmfBridging
{
    public string SmfID { get; set; } = null!;

    public string BridgingID { get; set; } = null!;

    public string BridgingName { get; set; } = null!;

    public string SRBridgingType { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
