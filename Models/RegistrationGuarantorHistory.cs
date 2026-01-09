using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationGuarantorHistory
{
    public string RegistrationNo { get; set; } = null!;

    public string FromGuarantorID { get; set; } = null!;

    public string ToGuarantorID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
