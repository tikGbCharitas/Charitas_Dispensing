using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PcareBridgingKunjungan
{
    public string PcareKunjunganID { get; set; } = null!;

    public string Appointment { get; set; } = null!;

    public string MethodAPI { get; set; } = null!;

    public string KdPpk { get; set; } = null!;

    public string? RegistrationNo { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? RegistrationVisitDate { get; set; }

    public DateTime OutRegistrationDate { get; set; }

    public string GuarantorCardNo { get; set; } = null!;

    public string ServiceUnitIDPcare { get; set; } = null!;

    public string? NoKunjungan { get; set; }

    public string Keluhan { get; set; } = null!;

    public string? KdKhusus { get; set; }

    public string? KdSubSpesialis { get; set; }

    public string? KdSarana { get; set; }

    public string? NotesKunjungan { get; set; }

    public string KdSadar { get; set; } = null!;

    public string KdDokter { get; set; } = null!;

    public string KdDiag1 { get; set; } = null!;

    public string? KdDiag2 { get; set; }

    public string? KdDiag3 { get; set; }

    public string KdStatusPulang { get; set; } = null!;

    public string? KdTacc { get; set; }

    public string? NotesTacc { get; set; }

    public string ResponseRaw { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
