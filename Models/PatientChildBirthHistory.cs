using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientChildBirthHistory
{
    public string PatientID { get; set; } = null!;

    public int SequenceNo { get; set; }

    public string? ChildBirth { get; set; }

    public string? Sex { get; set; }

    public string? Helper { get; set; }

    public string? Location { get; set; }

    public string? HM { get; set; }

    public string? BBL { get; set; }

    public string? Complication { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? PregnanDurationMonth { get; set; }

    public int? PregnanDurationWeek { get; set; }

    public string? SRBirthMethod { get; set; }
}
