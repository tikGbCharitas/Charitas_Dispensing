using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MonthlyAttendanceDetail
{
    public int MonthlyAttendanceDetailID { get; set; }

    public int PersonID { get; set; }

    public int PayrollPeriodID { get; set; }

    public DateTime CheckInDate { get; set; }

    public string? CheckInTime { get; set; }

    public DateTime CheckOutDate { get; set; }

    public string? CheckOutTime { get; set; }

    public bool IsOvertime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRAttendanceFileFormat { get; set; }
}
