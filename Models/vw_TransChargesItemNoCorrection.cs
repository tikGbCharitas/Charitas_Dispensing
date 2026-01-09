using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_TransChargesItemNoCorrection
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ReferenceNo { get; set; } = null!;

    public string ReferenceSequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ChargeClassID { get; set; } = null!;

    public string? ParamedicID { get; set; }

    public string? SecondParamedicID { get; set; }

    public bool IsAdminCalculation { get; set; }

    public bool IsVariable { get; set; }

    public bool IsCito { get; set; }

    public decimal? ChargeQuantity { get; set; }

    public decimal StockQuantity { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public decimal CostPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal CitoAmount { get; set; }

    public decimal RoundingAmount { get; set; }

    public string SRDiscountReason { get; set; } = null!;

    public bool IsAssetUtilization { get; set; }

    public string AssetID { get; set; } = null!;

    public bool IsBillProceed { get; set; }

    public bool IsOrderRealization { get; set; }

    public bool IsPackage { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public string Notes { get; set; } = null!;

    public string FilmNo { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? ParentNo { get; set; }

    public string? SRCenterID { get; set; }

    public decimal AutoProcessCalculation { get; set; }
}
