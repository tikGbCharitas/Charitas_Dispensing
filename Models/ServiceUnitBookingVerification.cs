using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitBookingVerification
{
    public int ServiceUnitBookingVerificationID { get; set; }

    public string? BookingNo { get; set; }

    public string? RegistrationNo { get; set; }

    public string? PatientID { get; set; }

    public string? ParamedicIDAnestesi { get; set; }

    public string? DPJP { get; set; }

    public string? SurgeryStatus { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? RoomID { get; set; }

    public string? Notes { get; set; }

    public string? Diagnose { get; set; }

    public string? SRAnestesiPlan { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? LastApprovedDateTime { get; set; }

    public string? LastApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastVoidDateTime { get; set; }

    public string? LastVoidByUserID { get; set; }

    public DateTime? BookingDateTimeFrom { get; set; }

    public DateTime? BookingDateTimeTo { get; set; }

    public DateTime? OriginBookingDateTimeFrom { get; set; }

    public DateTime? OriginBookingDateTimeTo { get; set; }

    public DateTime? EstimatedBookingDateTimeFrom { get; set; }

    public DateTime? EstimatedBookingDateTimeTo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual ICollection<ParamedicServiceUnitBookingVerification> ParamedicServiceUnitBookingVerifications { get; set; } = new List<ParamedicServiceUnitBookingVerification>();

    public virtual ICollection<ServiceUnitBookingVerificationLog> ServiceUnitBookingVerificationLogs { get; set; } = new List<ServiceUnitBookingVerificationLog>();
}
