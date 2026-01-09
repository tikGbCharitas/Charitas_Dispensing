using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesHistory
{
    public string RecalculationProcessNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public DateTime ExecutionDate { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public string FromServiceUnitID { get; set; } = null!;

    public string? ToServiceUnitID { get; set; }

    public string ClassID { get; set; } = null!;

    public string? RoomID { get; set; }

    public string? BedID { get; set; }

    public DateTime DueDate { get; set; }

    public string? SRShift { get; set; }

    public string? SRItemType { get; set; }

    public bool IsProceed { get; set; }

    public bool IsApproved { get; set; }

    public bool IsVoid { get; set; }

    public bool IsOrder { get; set; }

    public bool IsCorrection { get; set; }

    public bool IsClusterAssign { get; set; }

    public bool IsAutoBillTransaction { get; set; }

    public bool IsBillProceed { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? SRTypeResult { get; set; }

    public string? ResponUnitID { get; set; }
}
