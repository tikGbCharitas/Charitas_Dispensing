using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Class
{
    public string ClassID { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string SRClassRL { get; set; } = null!;

    public decimal MarginPercentage { get; set; }

    public decimal DepositAmount { get; set; }

    public bool IsInPatientClass { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? Margin2Percentage { get; set; }

    public string? BpjsClassID { get; set; }

    public bool? IsNeedValidatedOnReg { get; set; }
}
