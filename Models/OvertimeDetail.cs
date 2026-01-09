using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OvertimeDetail
{
    public int OvertimeDetailID { get; set; }

    public int OvertimeID { get; set; }

    public decimal HourFrom { get; set; }

    public decimal HourTo { get; set; }

    public decimal Value { get; set; }

    public decimal? Formula { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
