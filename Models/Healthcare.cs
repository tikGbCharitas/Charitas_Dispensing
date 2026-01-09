using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Healthcare
{
    public string HealthcareID { get; set; } = null!;

    public string? HealthcareName { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? ZipCode { get; set; }

    public string? PhoneNo { get; set; }

    public string? FaxNo { get; set; }

    public string? HospitalCode { get; set; }

    public string? FoundationName { get; set; }

    public string? FoundationAddr1 { get; set; }

    public string? FoundationAddr2 { get; set; }

    public string? FoundationCity { get; set; }

    public string? FoundationZipCode { get; set; }

    public string? FoundationPhoneNo { get; set; }

    public string? FoundationFaxNo { get; set; }

    public string? EmailAddr { get; set; }

    public string? Website { get; set; }

    public string? NPWP { get; set; }

    public string? HospitalType { get; set; }

    public string? Provinces { get; set; }

    public byte[]? HealthcareLogo { get; set; }

    public string? IDPropinsi { get; set; }

    public string? IDKabKota { get; set; }

    public string? IDKecamatan { get; set; }

    public string? IDKelurahan { get; set; }

    public string? Longitude { get; set; }

    public string? Latitude { get; set; }

    public string? Altitude { get; set; }
}
