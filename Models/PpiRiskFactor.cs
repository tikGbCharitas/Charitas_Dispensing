using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PpiRiskFactor
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string SRRiskFactorsType { get; set; } = null!;

    public string RiskFactorsID { get; set; } = null!;

    public string? SRRiskFactorsLocation { get; set; }

    public DateTime? DateOfInitialInstallation { get; set; }

    public DateTime? DateOfFinalInstallation { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
