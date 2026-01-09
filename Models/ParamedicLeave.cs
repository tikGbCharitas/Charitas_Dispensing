using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicLeave
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string ParamedicID { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string SRPhysicianLeaveReason { get; set; } = null!;

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? SubsParamedicIP { get; set; }

    public string? SubsParamedicOP { get; set; }

    public string? SubsParamedicEMR { get; set; }
}
