using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicAutoBillItem
{
    public string ParamedicID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsGenerateOnRegistration { get; set; }

    public bool IsGenerateOnReferral { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
