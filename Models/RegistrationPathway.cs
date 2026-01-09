using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationPathway
{
    public string RegistrationNo { get; set; } = null!;

    public string PathwayID { get; set; } = null!;

    public string? PathwayStatus { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
