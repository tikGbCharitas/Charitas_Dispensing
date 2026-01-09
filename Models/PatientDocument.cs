using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientDocument
{
    public long PatientDocumentID { get; set; }

    public string PatientID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string FileAttachName { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public DateTime? DocumentDate { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? OriFileName { get; set; }
}
