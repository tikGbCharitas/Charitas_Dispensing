using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Tmp_TranChargesPerShift
{
    public string? RegistrationNo { get; set; }

    public string? TransactionNo { get; set; }

    public string? SequenceNo { get; set; }

    public decimal? Price { get; set; }

    public decimal? ChargeQuantity { get; set; }

    public string? ParamedicCollectionName { get; set; }

    public string? ItemID { get; set; }

    public string? ItemName { get; set; }

    public string? ToServiceUnitID { get; set; }

    public DateTime? StampTime { get; set; }

    public string? CreatedBy { get; set; }

    public string? Shift { get; set; }

    public string? ShiftName { get; set; }
}
