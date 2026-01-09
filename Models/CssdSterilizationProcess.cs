using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CssdSterilizationProcess
{
    public string ProcessNo { get; set; } = null!;

    public DateTime ProcessDate { get; set; }

    public string ProcessStartTime { get; set; } = null!;

    public string ProcessEndTime { get; set; } = null!;

    public string MachineID { get; set; } = null!;

    public string SRCssdProcessType { get; set; } = null!;

    public string OperatorByUserID { get; set; } = null!;

    public string ProcessTo { get; set; } = null!;

    public bool? IsDtt { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
