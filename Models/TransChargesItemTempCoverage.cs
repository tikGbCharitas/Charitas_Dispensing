using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesItemTempCoverage
{
    public string RegistrationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ReferenceNo { get; set; } = null!;

    public string ReferenceSequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ChargeClassID { get; set; } = null!;

    public decimal ChargeQuantity { get; set; }

    public decimal Price { get; set; }

    public string? ParamedicCollectionName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
