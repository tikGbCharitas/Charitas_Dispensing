using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTariffRequest2
{
    public string TariffRequestNo { get; set; } = null!;

    public DateTime TariffRequestDate { get; set; }

    public string SRTariffType { get; set; } = null!;

    public string? SRItemType { get; set; }

    public DateTime StartingDate { get; set; }

    public string? Notes { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserID { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsImport { get; set; }
}
