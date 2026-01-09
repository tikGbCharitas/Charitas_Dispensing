using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationInfoMedicVitalSign
{
    public string RegistrationInfoMedicID { get; set; } = null!;

    public string VitalSignID { get; set; } = null!;

    public string VitalSignValueText { get; set; } = null!;

    public decimal? VitalSignValueNum { get; set; }

    public string? VitalSignUnit { get; set; }

    public string? EntryMask { get; set; }

    public string? RegistrationNo { get; set; }

    public string? SequenceNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
