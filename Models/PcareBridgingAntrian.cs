using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PcareBridgingAntrian
{
    public string PcareID { get; set; } = null!;

    public string Appointment { get; set; } = null!;

    public string MethodAPI { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    public string KdProviderPst { get; set; } = null!;

    public string GuarantorCardNo { get; set; } = null!;

    public string ServiceUnitIDPcare { get; set; } = null!;

    public string? NoAntrian { get; set; }

    public string? Keluhan { get; set; }

    public bool KunjSakit { get; set; }

    public bool RujukBalik { get; set; }

    public string KdTkp { get; set; } = null!;

    public bool StatusPatient { get; set; }

    public string ResponseRaw { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
