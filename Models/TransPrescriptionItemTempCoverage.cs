using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionItemTempCoverage
{
    public string RegistrationNo { get; set; } = null!;

    public string PrescriptionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ChargeClassID { get; set; } = null!;

    public decimal ResultQty { get; set; }

    public decimal Price { get; set; }

    public decimal LineAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
