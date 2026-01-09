using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MultiBatchItemMovement
{
    public decimal MultiBatchID { get; set; }

    public Guid? MovementID { get; set; }

    public DateTime? MovementDate { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? LocationID { get; set; }

    public string? TransactionNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? ItemID { get; set; }

    public decimal? QuantityIn { get; set; }

    public decimal? QuantityOut { get; set; }

    public DateTime? LastUpdateByDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal MultiBatchItemMovementID { get; set; }

    public virtual MultiBatch MultiBatch { get; set; } = null!;
}
