using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnit
{
    public string ServiceUnitID { get; set; } = null!;

    public string DepartmentID { get; set; } = null!;

    public string ServiceUnitName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string ServiceUnitOfficer { get; set; } = null!;

    public string? LocationID { get; set; }

    public string SRRegistrationType { get; set; } = null!;

    public bool IsUsingJobOrder { get; set; }

    public bool IsPatientTransaction { get; set; }

    public bool IsTransactionEntry { get; set; }

    public bool? IsDispensaryUnit { get; set; }

    public bool? IsPurchasingUnit { get; set; }

    public bool IsGenerateMedicalNo { get; set; }

    public bool IsActive { get; set; }

    public int? ChartOfAccountIdIncome { get; set; }

    public int? SubledgerIdIncome { get; set; }

    public int? ChartOfAccountIdAcrual { get; set; }

    public int? SubledgerIdAcrual { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? ChartOfAccountIdCost { get; set; }

    public int? SubledgerIdCost { get; set; }

    public bool? IsDirectPayment { get; set; }

    public int? ChartOfAccountIdCostNonMedic { get; set; }

    public int? SubledgerIdCostNonMedic { get; set; }

    public string? SRGenderType { get; set; }

    public string? ServiceUnitPharmacyID { get; set; }

    public int? ChartOfAccountIdCostParamedicFee { get; set; }

    public int? SubledgerIdCostParamedicFee { get; set; }

    public string? SRServiceUnitGroup { get; set; }

    public string? SRAssessmentType { get; set; }

    public bool? IsNeedConfirmationOfAttendance { get; set; }

    public string? LocationPharmacyID { get; set; }

    public string? Email { get; set; }

    public string? ServiceUnitIDBPJS { get; set; }

    public string? ServiceUnitPorID { get; set; }

    public string? LocationPorID { get; set; }

    public int? ChartOfAccountIdPpnIn { get; set; }

    public int? SubledgerIdPpnIn { get; set; }

    public bool? IsAllowAccessPatientWithServiceUnitParamedic { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<ServiceUnitBooking> ServiceUnitBookings { get; set; } = new List<ServiceUnitBooking>();
}
