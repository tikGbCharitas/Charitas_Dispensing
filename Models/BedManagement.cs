using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BedManagement
{
    public long BedManagementID { get; set; }

    public string BedID { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string? PatientID { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? StreetName { get; set; }

    public string? District { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? PhoneNo { get; set; }

    public string? MobilePhoneNo { get; set; }

    public string? FaxNo { get; set; }

    public string? Email { get; set; }

    public string? ReservationNo { get; set; }

    public string? RegistrationNo { get; set; }

    public string? RegistrationBedID { get; set; }

    public string SRBedStatus { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public bool? IsReleased { get; set; }

    public DateTime? ReleasedDateTime { get; set; }

    public string? ReleasedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
