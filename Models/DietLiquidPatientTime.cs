using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DietLiquidPatientTime
{
    public string TransactionNo { get; set; } = null!;

    public string DietTime { get; set; } = null!;

    public string FoodID { get; set; } = null!;

    public string? Measure { get; set; }

    public decimal? AmountOfWater { get; set; }

    public string? Etc { get; set; }

    public decimal? Total { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
