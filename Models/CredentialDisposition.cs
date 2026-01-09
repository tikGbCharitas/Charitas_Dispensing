using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialDisposition
{
    public string DispositionNo { get; set; } = null!;

    public DateTime DispositionDate { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
