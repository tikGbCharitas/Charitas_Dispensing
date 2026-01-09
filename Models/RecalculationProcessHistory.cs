using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RecalculationProcessHistory
{
    public string RecalculationProcessNo { get; set; } = null!;

    public DateTime RecalculationProcessDate { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string FromGuarantorID { get; set; } = null!;

    public string ToGuarantorID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
