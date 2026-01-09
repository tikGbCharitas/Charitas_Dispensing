using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitTransactionCode
{
    public string ServiceUnitID { get; set; } = null!;

    public string SRTransactionCode { get; set; } = null!;

    public bool? IsItemProductMedic { get; set; }

    public bool? IsItemProductNonMedic { get; set; }

    public bool? IsItemKitchen { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
