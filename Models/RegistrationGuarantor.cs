using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationGuarantor
{
    public string RegistrationNo { get; set; } = null!;

    public string GuarantorID { get; set; } = null!;

    public decimal? PlafondAmount { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRBusinessMethod { get; set; }

    public string? CoverageClassID { get; set; }

    public int? SequenceNo { get; set; }

    public string? SRPlafonOption { get; set; }
}
