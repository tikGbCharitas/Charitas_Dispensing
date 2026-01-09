using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeByNumberOfPatientsRangeAmount
{
    public int CounterID { get; set; }

    public short? MinAmount { get; set; }

    public short? MaxAmount { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
