using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalIdentification
{
    public int PersonalIdentificationID { get; set; }

    public int PersonID { get; set; }

    public string SRIdentificationType { get; set; } = null!;

    public string? IdentificationValue { get; set; }

    public string? PlaceOfIssue { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
