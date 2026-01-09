using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PathologyAnatomyTissue
{
    public string TissueID { get; set; } = null!;

    public string? TissueName { get; set; }

    public string? SourceOfTissueID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
