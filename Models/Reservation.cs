using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Reservation
{
    public string ReservationNo { get; set; } = null!;

    public DateTime ReservationDate { get; set; }

    public string PatientID { get; set; } = null!;

    public string? DepartmentID { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? RoomID { get; set; }

    public string? ClassID { get; set; }

    public string BedID { get; set; } = null!;

    public string SRReservationStatus { get; set; } = null!;

    public DateTime? FollowUpDateTime { get; set; }

    public string? FollowUpByUserID { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? FirstName { get; set; }

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

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }
}
