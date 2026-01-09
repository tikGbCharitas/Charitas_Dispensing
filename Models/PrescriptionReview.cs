using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PrescriptionReview
{
    public string PrescriptionNo { get; set; } = null!;

    public string SRPrescReview { get; set; } = null!;

    public bool? IsRight { get; set; }

    public string? Information { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
