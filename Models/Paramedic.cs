using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Paramedic
{
    public string ParamedicID { get; set; } = null!;

    public string ParamedicName { get; set; } = null!;

    public string ParamedicInitial { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string SRParamedicType { get; set; } = null!;

    public string SRParamedicStatus { get; set; } = null!;

    public string SRReligion { get; set; } = null!;

    public string SRNationality { get; set; } = null!;

    public string SRSpecialty { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public string LicenseNo { get; set; } = null!;

    public string TaxRegistrationNo { get; set; } = null!;

    public bool IsPKP { get; set; }

    public bool IsAvailable { get; set; }

    public DateTime? NotAvailableUntil { get; set; }

    public bool IsAnesthetist { get; set; }

    public bool IsAudiologist { get; set; }

    public bool IsActive { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public DateTime? LicensePeriodeStart { get; set; }

    public DateTime? LicensePeriodeEnd { get; set; }

    public bool? IsParamedicFeeUsePercentage { get; set; }

    public decimal? ParamedicFeeAmount { get; set; }

    public string? Bank { get; set; }

    public string? BankAccount { get; set; }

    public decimal? ParamedicFeeAmountReferral { get; set; }

    public bool? IsUsingQue { get; set; }

    public string? SRParamedicRL1 { get; set; }

    public bool? IsDeductionFeeUsePercentage { get; set; }

    public decimal? DeductionFeeAmount { get; set; }

    public decimal? DeductionFeeAmountReferral { get; set; }

    public int? ChartOfAccountIdAPParamedicFee { get; set; }

    public int? SubledgerIdAPParamedicFee { get; set; }

    public bool? ParamedicFee { get; set; }

    public bool? IsPrintInSlip { get; set; }

    public string? SSN { get; set; }

    public string? SRTypeDoctor { get; set; }

    public string? SRCompetencyDoctor { get; set; }

    public virtual ICollection<ParamedicSchedule> ParamedicSchedules { get; set; } = new List<ParamedicSchedule>();

    public virtual ICollection<ParamedicServiceUnitBookingVerification> ParamedicServiceUnitBookingVerifications { get; set; } = new List<ParamedicServiceUnitBookingVerification>();

    public virtual ICollection<ServiceUnitBooking> ServiceUnitBookings { get; set; } = new List<ServiceUnitBooking>();
}
