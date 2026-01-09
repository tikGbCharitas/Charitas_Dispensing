using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Appointment
{
    public string AppointmentNo { get; set; } = null!;

    public int? AppointmentQue { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string? PatientID { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string? AppointmentTime { get; set; }

    public string VisitTypeID { get; set; } = null!;

    public byte VisitDuration { get; set; }

    public string SRAppointmentStatus { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

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

    public string Notes { get; set; } = null!;

    public string? PatientPIC { get; set; }

    public string? OfficerPIC { get; set; }

    public DateTime? FollowUpDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateByUserID { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? GuarantorID { get; set; }

    public string? FromRegistrationNo { get; set; }

    public string? AppointmentMethod { get; set; }

    public string? no_ref { get; set; }

    public string? clientid { get; set; }

    public string? SRReferralGroup { get; set; }

    public string? ReferralID { get; set; }

    public string? SRMemberChr { get; set; }

    public bool? MemberVIP { get; set; }

    public bool? IsDocumentComplete { get; set; }

    public string? Whatsapp { get; set; }

    public string? QuestionAnswers { get; set; }

    public string? DocumentLocation { get; set; }

    public int? StatusDocuments { get; set; }

    public string? FollowUpDocuments { get; set; }

    public string? DeviceToken { get; set; }
}
