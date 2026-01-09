using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SpectaclePrescriptionItem
{
    public string PrescriptionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal CostPrice { get; set; }

    public decimal InitialPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string SRDiscountReason { get; set; } = null!;

    public string OdSphere { get; set; } = null!;

    public string OdCyl { get; set; } = null!;

    public string OdAxis { get; set; } = null!;

    public string OdPrism { get; set; } = null!;

    public string? OdBase { get; set; }

    public string OdMpd { get; set; } = null!;

    public string? OdPv { get; set; }

    public string? OdSh { get; set; }

    public string? OdAdd { get; set; }

    public string OsSphere { get; set; } = null!;

    public string OsCyl { get; set; } = null!;

    public string OsAxis { get; set; } = null!;

    public string OsPrism { get; set; } = null!;

    public string? OsBase { get; set; }

    public string OsMpd { get; set; } = null!;

    public string? OsPv { get; set; }

    public string? OsSh { get; set; }

    public string? OsAdd { get; set; }

    public string Notes { get; set; } = null!;

    public string? FrameA { get; set; }

    public string? FrameB { get; set; }

    public string? Bridge { get; set; }

    public string? FrameDia { get; set; }

    public bool IsVoid { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsApprove { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public decimal AutoProcessCalculation { get; set; }
}
