using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientReceivableMonthlySummaryDetail
{
    public long DetailID { get; set; }

    public int? ID { get; set; }

    public string? SRBillingGroup { get; set; }

    public int? ChartOfAccountId { get; set; }

    public decimal? Amount { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
