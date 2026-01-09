using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientGenogram
{
    public string PatientID { get; set; } = null!;

    public byte[]? Genogram { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
