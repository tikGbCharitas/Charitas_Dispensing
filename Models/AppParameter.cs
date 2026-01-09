using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppParameter
{
    public string ParameterID { get; set; } = null!;

    public string ParameterName { get; set; } = null!;

    public string? ParameterValue { get; set; }

    public string? ParameterType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool IsUsedBySystem { get; set; }
}
