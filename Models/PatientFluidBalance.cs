using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientFluidBalance
{
    public string RegistrationNo { get; set; } = null!;

    public int SequenceNo { get; set; }

    public DateOnly InOutDate { get; set; }

    public string? SchemaInfus { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? LastTemp { get; set; }

    public int? IwlForHour { get; set; }
}
