using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Utilization
{
    public string UtilizationID { get; set; } = null!;

    public decimal? MaximumHour { get; set; }

    public decimal? OptimumHour { get; set; }

    public decimal? BreakPeriod { get; set; }

    public decimal? ExaminationTime { get; set; }

    public decimal? PurchasePrice { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? UtilizationName { get; set; }

    public decimal? BEPYear { get; set; }

    public int? quantity { get; set; }
}
