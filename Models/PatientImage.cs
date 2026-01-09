using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientImage
{
    public string PatientID { get; set; } = null!;

    public byte[]? Photo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
