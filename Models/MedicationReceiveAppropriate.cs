using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicationReceiveAppropriate
{
    public long MedicationReceiveNo { get; set; }

    public string AppropriateType { get; set; } = null!;

    public string? SRMedicationNotAppropriateReason { get; set; }

    public string? MedicationReason { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CratedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
