using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesItem
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ReferenceNo { get; set; } = null!;

    public string ReferenceSequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ChargeClassID { get; set; } = null!;

    public string? ParamedicID { get; set; }

    /// <summary>
    /// Diisi untuk rawat inap oelh Dokter Pengganti atau dokter anestesi
    /// </summary>
    public string? SecondParamedicID { get; set; }

    public bool IsAdminCalculation { get; set; }

    public bool IsVariable { get; set; }

    public bool IsCito { get; set; }

    public decimal ChargeQuantity { get; set; }

    public decimal StockQuantity { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public decimal CostPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal CitoAmount { get; set; }

    public decimal RoundingAmount { get; set; }

    public string SRDiscountReason { get; set; } = null!;

    public bool? IsAssetUtilization { get; set; }

    public string? AssetID { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsOrderRealization { get; set; }

    public bool IsPackage { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public string? Notes { get; set; }

    public string FilmNo { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? ParentNo { get; set; }

    public string? SRCenterID { get; set; }

    public decimal AutoProcessCalculation { get; set; }

    public string? ParamedicCollectionName { get; set; }

    public string? ToServiceUnitID { get; set; }

    public DateTime? RealizationDateTime { get; set; }

    public string? RealizationUserID { get; set; }

    public DateTime? UpdateRealizationDateTime { get; set; }

    public string? UpdateRealizationUserID { get; set; }

    public bool? IsCitoInPercent { get; set; }

    public decimal? BasicCitoAmount { get; set; }

    public bool? IsItemRoom { get; set; }

    public bool? IsExtraItem { get; set; }

    public bool? IsSelectedExtraItem { get; set; }

    public bool? IsSendToLIS { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public bool? IsCorrection { get; set; }

    public string? ResultValue { get; set; }

    public bool? IsDuplo { get; set; }

    public bool? IsPaymentConfirmed { get; set; }

    public DateTime? PaymentConfirmedDateTime { get; set; }

    public string? PaymentConfirmedBy { get; set; }

    public DateTime? LastPaymentConfirmedDateTime { get; set; }

    public string? LastPaymentConfirmedByUserID { get; set; }

    public bool? IsDescriptionResult { get; set; }

    public decimal? PriceAdjusted { get; set; }

    public string? SRCitoPercentage { get; set; }

    public bool? IsExamination { get; set; }

    public DateTime? ExaminationDateTime { get; set; }

    public bool? IsAutobillGuarantor { get; set; }

    public virtual TransCharge TransactionNoNavigation { get; set; } = null!;
}
