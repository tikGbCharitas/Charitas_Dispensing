using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PathologyAnatomySourceOfTissue
{
    public string SourceOfTissueID { get; set; } = null!;

    public string SourceOfTissueName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
