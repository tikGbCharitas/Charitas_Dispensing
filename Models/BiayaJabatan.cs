using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BiayaJabatan
{
    public int BiayaJabatanID { get; set; }

    public DateTime ValidFrom { get; set; }

    public decimal AmountOfDeduction { get; set; }

    public decimal PercentOfDeduction { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
