using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalFileStatus
{
    public string PatientID { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string? SRMedicalFileStatusCategory { get; set; }

    public string? SRMedicalFileStatus { get; set; }

    public string? Expeditor { get; set; }

    public string? DepartmentID { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? ParamedicID { get; set; }

    public string? Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
