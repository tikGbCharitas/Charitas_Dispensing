using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientHealthRecord
{
    public string TransactionNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string QuestionFormID { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public string RecordTime { get; set; } = null!;

    /// <summary>
    /// Examiner
    /// </summary>
    public string EmployeeID { get; set; } = null!;

    public bool? IsComplete { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ExaminerID { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? ServiceUnitID { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDatetime { get; set; }

    public string? ApprovedByUserID { get; set; }
}
