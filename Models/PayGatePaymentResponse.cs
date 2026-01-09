using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PayGatePaymentResponse
{
    public int ID { get; set; }

    public string? member_id { get; set; }

    public string? comm_code { get; set; }

    public string? signature { get; set; }

    public string? order_id { get; set; }

    public string? rq_uuid { get; set; }

    public string? rq_datetime { get; set; }

    public string? ccy { get; set; }

    public decimal? amount { get; set; }

    public string? debit_from { get; set; }

    public string? debit_from_name { get; set; }

    public string? credit_to { get; set; }

    public string? credit_to_name { get; set; }

    public string? product_code { get; set; }

    public string? message { get; set; }

    public string? payment_datetime { get; set; }

    public string? payment_ref { get; set; }

    public string? debit_from_bank { get; set; }

    public string? credit_to_bank { get; set; }

    public string? approval_code_full_bca { get; set; }

    public string? approval_code_installment_bca { get; set; }

    public string? reconcile_id { get; set; }

    public DateTime? create_datetime { get; set; }

    public string? SysNotes { get; set; }

    public int? mobile_app_notif_count { get; set; }

    public DateTime? mobile_app_notif_lastupdatedate { get; set; }
}
