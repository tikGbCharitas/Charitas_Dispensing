using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransCharge
{
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

    public string? SurgicalPackageID { get; set; }

    public bool? IsPackage { get; set; }

    public string? PackageReferenceNo { get; set; }

    public bool? IsRoomIn { get; set; }

    public decimal? TariffDiscountForRoomIn { get; set; }

    public bool? IsNonPatient { get; set; }

    public string? ServiceUnitBookingNo { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public string? PhysicianSenders { get; set; }

    public bool? IsValidated { get; set; }

    public DateTime? ValidatedDateTime { get; set; }

    public string? ValidatedByUserID { get; set; }

    public string? LocationID { get; set; }

    public string? SRProdiaContractID { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    public virtual ICollection<TransChargesItem> TransChargesItems { get; set; } = new List<TransChargesItem>();
}
