using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PayGateBilling
{
    public int ID { get; set; }

    public string? TransactionID { get; set; }

    public string? RegistrationNo { get; set; }

    public string? RegistrationNoList { get; set; }

    public string? IntermBillNoList { get; set; }

    public bool? IsVoid { get; set; }

    public bool? isPaid { get; set; }

    public string? PaymnentUrl { get; set; }

    public int? HitCount { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
