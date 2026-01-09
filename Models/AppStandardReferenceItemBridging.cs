using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppStandardReferenceItemBridging
{
    public string StandardReferenceID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string SRBridgingType { get; set; } = null!;

    public string BridgingID { get; set; } = null!;

    public string BridgingName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string SRRegistrationType { get; set; } = null!;
}
