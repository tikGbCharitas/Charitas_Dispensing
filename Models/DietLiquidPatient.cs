using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DietLiquidPatient
{
    public string TransactionNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public DateTime EffectiveStartDate { get; set; }

    public string EffectiveStartTime { get; set; } = null!;

    public string? Notes { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
