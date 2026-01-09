using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPaymentItemVisite
{
    public string PaymentNo { get; set; } = null!;

    public string PatientID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public int VisiteQty { get; set; }

    public int RealizationQty { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public bool IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ServiceUnitID { get; set; }

    public DateTime? ExpiredDate { get; set; }
}
