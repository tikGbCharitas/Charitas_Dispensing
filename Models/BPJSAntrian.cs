using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BPJSAntrian
{
    public long BPJSAntrianID { get; set; }

    public string? AppointmentNo { get; set; }

    public string? RegistrationNo { get; set; }

    public int? StatusAntrian { get; set; }

    public DateTime? Task1 { get; set; }

    public DateTime? Task2 { get; set; }

    public DateTime? Task3 { get; set; }

    public DateTime? Task4 { get; set; }

    public DateTime? Task5 { get; set; }

    public DateTime? Task6 { get; set; }

    public DateTime? Task7 { get; set; }

    public DateTime? Task99 { get; set; }

    public DateTime? TglAntrian { get; set; }

    public int? nourutAntrianlama { get; set; }

    public string? ParamSystemAntrian { get; set; }

    public string? createby { get; set; }

    public DateTime? createdate { get; set; }

    public string? nourutAntrian { get; set; }

    public string? AppointmentMethod { get; set; }

    public bool? StatusSEP { get; set; }

    public string? BpjsSepNo { get; set; }

    public string? UrlBpjs { get; set; }

    public int? StatusCode { get; set; }

    public string? Reply { get; set; }

    public DateTime? updatedate { get; set; }

    public DateTime? Successdate { get; set; }
}
