using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicationReceiveStatus
{
    public long MedicationReceiveNo { get; set; }

    public DateTime StatusDateTime { get; set; }

    public bool? IsMedicationStop { get; set; }

    public string? SRMedicationStopReason { get; set; }

    public string? MedicationReason { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
