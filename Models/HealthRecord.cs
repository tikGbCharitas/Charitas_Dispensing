using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class HealthRecord
{
    public string PatientID { get; set; } = null!;

    public string QuestionFormID { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public string RecordTime { get; set; } = null!;

    public string? EmployeeID { get; set; }

    public bool? IsComplete { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
