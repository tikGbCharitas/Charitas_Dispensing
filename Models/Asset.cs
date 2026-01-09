using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Asset
{
    public string AssetID { get; set; } = null!;

    public string AssetGroupID { get; set; } = null!;

    public string AssetLocationID { get; set; } = null!;

    public string DepartmentID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string AssetName { get; set; } = null!;

    public string? AssetBookID { get; set; }

    public string SRAssetType { get; set; } = null!;

    public string SRManufacturer { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public string DepreciationMethodID { get; set; } = null!;

    public string ItemUnit { get; set; } = null!;

    public string PurchaseOrderNumber { get; set; } = null!;

    public DateTime PurchasedDate { get; set; }

    public DateTime StartDepreciationDate { get; set; }

    public DateTime StartUsingDate { get; set; }

    public decimal PurchasedPrice { get; set; }

    public byte UsageTimeEstimation { get; set; }

    public byte AgeOfDepreciation { get; set; }

    public decimal SalesPrice { get; set; }

    public decimal CurrentValue { get; set; }

    public decimal CurrentCondition { get; set; }

    public byte CurrentUsageTimeEstimation { get; set; }

    public decimal ResidualValue { get; set; }

    public string InsuranceID { get; set; } = null!;

    public string InsurancePolicyNo { get; set; } = null!;

    public decimal InsuranceAmount { get; set; }

    public DateTime GuaranteeExpiredDate { get; set; }

    public DateTime LastInventoriedDate { get; set; }

    public string LastInventoriedBy { get; set; } = null!;

    public DateTime? LastMaintenanceDate { get; set; }

    public DateTime? NextMaintenanceDate { get; set; }

    public byte MaintenanceInterval { get; set; }

    public string? MaintenanceIntervalIn { get; set; }

    public string? MaintenanceServiceUnitID { get; set; }

    public DateTime IssuedDate { get; set; }

    public string IssuedBy { get; set; } = null!;

    public string SRIssuedReason { get; set; } = null!;

    public string IntervalUnit { get; set; } = null!;

    public string ReferenceNo { get; set; } = null!;

    public bool IsAudiometer { get; set; }

    public bool IsSpirometer { get; set; }

    public bool IsActive { get; set; }

    public string Notes { get; set; } = null!;

    public string? SRAssetsStatus { get; set; }

    public string? SRAssetsCondition { get; set; }

    public string? SRAssetsCriticality { get; set; }

    public string? NotesToTechnician { get; set; }

    public string? SupplierID { get; set; }

    public string? SRAssetsWarrantyContract { get; set; }

    public string? WarrantyContractNotes { get; set; }

    public DateTime? DateDisposed { get; set; }

    public string? ItemID { get; set; }

    public bool? IsContinuousMaintenanceSchedule { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? AssetSubGroupId { get; set; }
}
