using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MultiBatchTemp
{
    public string TransactionNo { get; set; } = null!;

    public string? SequenceNo { get; set; }

    public string ItemID { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string? BatchID { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? NIE_BPOM { get; set; }

    public string? SRItemUnit { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public int? BinID { get; set; }

    public Guid MBTempID { get; set; }

    public string? Barcode { get; set; }

    public string? Status { get; set; }

    public string? StatusByUserID { get; set; }

    public DateTime? StatusByDateTime { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceSequenceNo { get; set; }

    public string? LocationID { get; set; }
}
