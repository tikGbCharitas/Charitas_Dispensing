using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AVCAnnounce
{
    public string? RegistrationNo { get; set; }

    public string? SRLantai { get; set; }

    public DateTime? CallTime { get; set; }

    public DateTime? FinishTime { get; set; }

    public string? Type { get; set; }

    public string? CounterType { get; set; }

    public int? DisplayID { get; set; }

    public string? PrescriptionNo { get; set; }

    public int AnnounceID { get; set; }
}
