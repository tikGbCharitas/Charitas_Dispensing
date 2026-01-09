using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PpiRiskFactorsItem
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public DateTime DateOfInfection { get; set; }

    public string SRSignsOfInfection { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
