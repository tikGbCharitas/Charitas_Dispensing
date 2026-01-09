using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientDocumentImage
{
    public string PatientID { get; set; } = null!;

    public int SequenceNo { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string? SRImageTemplateType { get; set; }

    public string? ImageTemplateID { get; set; }

    public string Name { get; set; } = null!;

    public string? Notes { get; set; }

    public byte[]? Image { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
