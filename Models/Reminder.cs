using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Reminder
{
    public long ReminderID { get; set; }

    public string? RegistrationNo { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? ParamedicID { get; set; }

    public DateOnly? ReminderDate { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateByUserID { get; set; }

    public string? FollowUp { get; set; }

    public DateTime? LastFollowUpDateTime { get; set; }
}
