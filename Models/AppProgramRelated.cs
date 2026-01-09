using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppProgramRelated
{
    public string ProgramID { get; set; } = null!;

    public string RelatedProgramID { get; set; } = null!;

    public string? ReferenceID { get; set; }
}
