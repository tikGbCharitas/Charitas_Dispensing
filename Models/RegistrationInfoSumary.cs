using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationInfoSumary
{
    public string RegistrationNo { get; set; } = null!;

    public int NoteCount { get; set; }

    public string CreatedByUserID { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public int NoteMedicalCount { get; set; }
}
