using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTariffRequestItemToImport
{
    public string ReferenceNo { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public string SRTariffType { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public decimal? OldPrice { get; set; }

    public decimal? NewPrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
