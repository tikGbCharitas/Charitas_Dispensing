using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OnlineBill
{
    public long OnlineBillID { get; set; }

    public string? noWA { get; set; }

    public string? RegistrationNo { get; set; }

    public bool? IsPaid { get; set; }

    public DateTime? PaidDate { get; set; }

    public bool? IsDelivered { get; set; }

    public string? Url { get; set; }

    public string? createby { get; set; }

    public DateTime? createdate { get; set; }

    public string? payload { get; set; }

    public string? IntermBillNo { get; set; }

    public DateTime? DeliveredDate { get; set; }

    public DateTime? RequestPickUpDate { get; set; }

    public string? OrderDeliveryID { get; set; }

    public string? Type { get; set; }

    public string? floor { get; set; }

    public string? Items { get; set; }

    public string? ProviderID { get; set; }

    public string? ProviderType { get; set; }

    public int? NumberOrder { get; set; }

    public int? StatusExplanation { get; set; }
}
