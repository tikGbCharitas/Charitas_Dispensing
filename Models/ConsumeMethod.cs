using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ConsumeMethod
{
    public string SRConsumeMethod { get; set; } = null!;

    public string SRConsumeMethodName { get; set; } = null!;

    public string TimeSequence { get; set; } = null!;

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateByUserID { get; set; }

    public string? SygnaText { get; set; }

    public int? IterationQty { get; set; }

    public string? IterationInInterval { get; set; }

    public string? Time01 { get; set; }

    public string? Time02 { get; set; }

    public string? Time03 { get; set; }

    public string? Time04 { get; set; }

    public string? Time05 { get; set; }

    public string? Time06 { get; set; }

    public string? Time07 { get; set; }

    public string? Time08 { get; set; }

    public string? Time09 { get; set; }

    public string? Time10 { get; set; }
}
