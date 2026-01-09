using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EpisodeBodyDiagram
{
    public string RegistrationNo { get; set; } = null!;

    public int SequenceNo { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public byte[]? BodyImage { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
