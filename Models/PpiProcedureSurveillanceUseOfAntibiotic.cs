using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PpiProcedureSurveillanceUseOfAntibiotic
{
    public string BookingNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
