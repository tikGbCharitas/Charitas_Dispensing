using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DietComplicationPatient
{
    public string TransactionNo { get; set; } = null!;

    public string DietID { get; set; } = null!;

    public string DietComplicationID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
