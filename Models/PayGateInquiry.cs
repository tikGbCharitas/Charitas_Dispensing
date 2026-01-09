using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PayGateInquiry
{
    public int ID { get; set; }

    public string? rq_uuid { get; set; }

    public string? rq_datetime { get; set; }

    public string? member_id { get; set; }

    public string? comm_code { get; set; }

    public string? order_id { get; set; }

    public string? password { get; set; }

    public string? signature { get; set; }

    public DateTime? Createdate { get; set; }
}
