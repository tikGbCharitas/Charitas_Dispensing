using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SickLetter
{
    public string RegistrationNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string SRLetterType { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
