using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_TransChargesItemCompParamedic
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string? ParamedicID { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsPackage { get; set; }

    public decimal AutoProcessCalculation { get; set; }
}
