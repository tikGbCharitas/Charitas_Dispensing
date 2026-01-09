using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EventMealOrder
{
    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime EventDate { get; set; }

    public string EventTime { get; set; } = null!;

    public string EventName { get; set; } = null!;

    public string Pic { get; set; } = null!;

    public short NoOfParticipant { get; set; }

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
