using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientAllergy
{
    public string AllergyGroup { get; set; } = null!;

    public string Allergen { get; set; } = null!;

    public string AllergenName { get; set; } = null!;

    public string SRAnaphylaxis { get; set; } = null!;

    public string Anaphylaxis { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string PatientID { get; set; } = null!;

    public string DescAndReaction { get; set; } = null!;
}
