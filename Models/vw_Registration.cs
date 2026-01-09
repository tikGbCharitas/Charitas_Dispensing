using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_Registration
{
    public string RegistrationNo { get; set; } = null!;

    public string? ParamedicID { get; set; }

    public string GuarantorID { get; set; } = null!;

    public string PatientID { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    public string RegistrationTime { get; set; } = null!;

    public byte AgeInYear { get; set; }

    public byte AgeInMonth { get; set; }

    public byte AgeInDay { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? RoomID { get; set; }

    public string? BedID { get; set; }

    public string? VisitTypeID { get; set; }

    public string? Anamnesis { get; set; }

    public string? Complaint { get; set; }

    public string? InitialDiagnose { get; set; }

    public string? MedicationPlanning { get; set; }
}
