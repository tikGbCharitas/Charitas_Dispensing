using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppointmentLokadok
{
    public long appt_id { get; set; }

    public long? start_date { get; set; }

    public long? end_date { get; set; }

    public int? place { get; set; }

    public string? p_id { get; set; }

    public string? p_name { get; set; }

    public long? p_dob { get; set; }

    public string? p_gender { get; set; }

    public string? p_mobile { get; set; }

    public string? p_insurance { get; set; }

    public string? p_ins_id { get; set; }

    public string? p_ins_number { get; set; }

    public string? lkd_pid { get; set; }

    public string? doc_id { get; set; }

    public string? doctor { get; set; }

    public string? doc_spc { get; set; }

    public string? poly_id { get; set; }

    public string? notes { get; set; }

    public string? reason_visit { get; set; }

    public string? confirmed { get; set; }

    public string? checked_in { get; set; }

    public bool? new_patient { get; set; }

    public string? booking_code { get; set; }

    public string? status { get; set; }

    public string? RegistrationNo { get; set; }

    public string? RegistrationNoSender { get; set; }
}
