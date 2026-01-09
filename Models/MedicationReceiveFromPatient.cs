using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicationReceiveFromPatient
{
    public long MedicationReceiveNo { get; set; }

    public DateTime? LastConsumeDateTime { get; set; }

    public string? Condition { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? ApprovedByParamedicID { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
