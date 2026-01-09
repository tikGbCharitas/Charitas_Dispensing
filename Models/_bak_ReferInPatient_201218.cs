using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class _bak_ReferInPatient_201218
{
    public string RegistrationNo { get; set; } = null!;

    public int SequenceNo { get; set; }

    public DateTime? ReferDateTime { get; set; }

    public string FromParamedicID { get; set; } = null!;

    public string ToParamedicID { get; set; } = null!;

    public string ActionExamTreatment { get; set; } = null!;

    public string? Notes { get; set; }

    public string? Answer { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
