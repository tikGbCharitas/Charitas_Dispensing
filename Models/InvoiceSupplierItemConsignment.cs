using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class InvoiceSupplierItemConsignment
{
    public string InvoiceNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
