using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationMeasuredGoal
{
    public string RegistrationNo { get; set; } = null!;

    public int SeqNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? SRUserType { get; set; }

    public string? Problem { get; set; }

    public string? Planning { get; set; }

    public string? Goal { get; set; }

    public int? IterationQty { get; set; }

    public int? Qty { get; set; }

    public string? SRTimeType { get; set; }

    public bool? IsVoid { get; set; }
}
