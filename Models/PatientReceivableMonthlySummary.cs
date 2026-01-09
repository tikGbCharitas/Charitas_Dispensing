using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientReceivableMonthlySummary
{
    public int ID { get; set; }

    public DateTime? Period { get; set; }

    public string? RegistrationNo { get; set; }

    public decimal? DownPayment { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
