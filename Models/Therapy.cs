using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Therapy
{
    public string TherapyID { get; set; } = null!;

    public string TherapyName { get; set; } = null!;

    public string SRTherapyGroup { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
