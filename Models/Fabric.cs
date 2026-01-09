using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Fabric
{
    public string FabricID { get; set; } = null!;

    public string FabricName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string ContractNumber { get; set; } = null!;

    public DateTime? ContractStart { get; set; }

    public DateTime? ContractEnd { get; set; }

    public string ContractSummary { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public bool IsPKP { get; set; }

    public string TaxRegistrationNo { get; set; } = null!;

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

    public virtual ICollection<SupplierFabric> SupplierFabrics { get; set; } = new List<SupplierFabric>();
}
