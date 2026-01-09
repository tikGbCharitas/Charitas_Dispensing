using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_HL7MessageParameter
{
    public string ADT { get; set; } = null!;

    public string PatientID { get; set; } = null!;

    public string? MedicalNo { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? DateOfBirth { get; set; }

    public string Sex { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string Nationality { get; set; } = null!;

    public string County { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public string CityOfBirth { get; set; } = null!;

    public string ServiceUnitName { get; set; } = null!;

    public string RoomName { get; set; } = null!;

    public string BedID { get; set; } = null!;

    public string? ParamedicID { get; set; }

    public string ParamedicName { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public int RegistrationQue { get; set; }

    public string? RegistrationDateTime { get; set; }

    public string? Complaint { get; set; }
}
