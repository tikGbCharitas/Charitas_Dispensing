using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Supplier
{
    public string SupplierID { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string SRSupplierType { get; set; } = null!;

    public string ContractNumber { get; set; } = null!;

    public DateTime? ContractStart { get; set; }

    public DateTime? ContractEnd { get; set; }

    public string ContractSummary { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public bool IsPKP { get; set; }

    public string TaxRegistrationNo { get; set; } = null!;

    public decimal? TermOfPayment { get; set; }

    public byte LeadTime { get; set; }

    public decimal CreditLimit { get; set; }

    public bool IsActive { get; set; }

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

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? ChartOfAccountIdAP { get; set; }

    public int? SubledgerIdAP { get; set; }

    public int? ChartOfAccountIdAPInProcess { get; set; }

    public int? SubledgerIdAPInProcess { get; set; }

    public decimal? TaxPercentage { get; set; }

    public int? ChartOfAccountIdAPTemporary { get; set; }

    public int? SubledgerIdAPTemporary { get; set; }

    public int? ChartOfAccountIdAPCost { get; set; }

    public int? SubledgerIdAPCost { get; set; }

    public string? PBFLicenseNo { get; set; }

    public DateTime? PBFLicenseValidDate { get; set; }

    public string? BankAccountNo { get; set; }

    public string? BankName { get; set; }

    public int? ChartOfAccountIdPOReturn { get; set; }

    public int? SubledgerIdPOReturn { get; set; }

    public string? SRApAgingDateType { get; set; }

    public int? ChartOfAccountIdAPNonMedic { get; set; }

    public int? SubledgerIdAPNonMedic { get; set; }

    public int? ChartOfAccountIdAPTemporaryNonMedic { get; set; }

    public int? SubledgerIdAPTemporaryNonMedic { get; set; }

    public int? ChartOfAccountIdPOReturnNonMedic { get; set; }

    public int? SubledgerIdPOReturnNonMedic { get; set; }

    public virtual ICollection<SupplierContract> SupplierContracts { get; set; } = new List<SupplierContract>();

    public virtual ICollection<SupplierFabric> SupplierFabrics { get; set; } = new List<SupplierFabric>();
}
