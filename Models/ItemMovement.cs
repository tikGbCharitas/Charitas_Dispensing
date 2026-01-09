using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemMovement
{
    public Guid MovementID { get; set; }

    public DateTime MovementDate { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string LocationID { get; set; } = null!;

    public string TransactionCode { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public DateTime? ExpiredDate { get; set; }

    public decimal? InitialStock { get; set; }

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public decimal CostPrice { get; set; }

    public decimal SalesPrice { get; set; }

    public decimal PurchasePrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? LastPriceInBaseUnit { get; set; }
}
