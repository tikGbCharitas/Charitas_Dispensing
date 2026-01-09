using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ClinicalPathway
{
    public string RegistrationNo { get; set; } = null!;

    public string PathwayID { get; set; } = null!;

    public int PathwayItemSeqNo { get; set; }

    public int DayNo { get; set; }

    public bool IsRealized { get; set; }

    public DateTime? RealizedDateTime { get; set; }

    public string? ReferenceNo { get; set; }

    public string? SRTransactionCode { get; set; }

    public string? ItemID { get; set; }

    public string? InterventionItemID { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
