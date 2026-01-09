using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialProcessLicense
{
    public string TransactionNo { get; set; } = null!;

    public string SRLicenseType { get; set; } = null!;

    public string LicenseNo { get; set; } = null!;

    public DateTime? DateOfIssue { get; set; }

    public DateTime? ValidUntil { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
