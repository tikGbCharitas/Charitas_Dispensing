using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_Appointment
{
    public string AppointmentNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string MedicalNo { get; set; } = null!;

    public string? PatientName { get; set; }

    public string MobilePhoneNo { get; set; } = null!;

    public string ParamedicName { get; set; } = null!;

    public string ParamedicInitial { get; set; } = null!;

    public DateTime AppointmentDate { get; set; }

    public string? AppointmentTime { get; set; }

    public string? AppointmentTimeConvert { get; set; }

    public int? AppointmentQue { get; set; }

    public string Weekdays { get; set; } = null!;

    public string Notes { get; set; } = null!;
}
