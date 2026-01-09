using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MultiBatch
{
    public decimal MultiBatchID { get; set; }

    public string? TransactionNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceSequenceNo { get; set; }

    public string? ItemID { get; set; }

    public string? NIE_BPOM { get; set; }

    public string? BatchID { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public decimal? Quantity { get; set; }

    public string? SRItemUnit { get; set; }

    public DateTime? LastUpdatebyTime { get; set; }

    public string? LastUpdatebyID { get; set; }

    public string? Status { get; set; }

    public DateTime? StatusByDateTime { get; set; }

    public string? StatusByUserID { get; set; }

    public string? Barcode { get; set; }

    public int? BinID { get; set; }

    public virtual MultiBatchItemBin? Bin { get; set; }

    public virtual ICollection<MultiBatchItemMovement> MultiBatchItemMovements { get; set; } = new List<MultiBatchItemMovement>();
}
