using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Customer
{
    public string CustomerID { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public bool IsActive { get; set; }

    public string StreetName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
