using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitBookingVerificationLog
{
    public int ServiceUnitBookingVerificationLogID { get; set; }

    public int ServiceUnitBookingVerificationID { get; set; }

    public string? SurgeryStatus { get; set; }

    public DateTime? TransactionDateTime { get; set; }

    public string? SSEncounterID { get; set; }

    public DateTime? SSRequestDateTime { get; set; }

    public DateTime? SSResponseDateTime { get; set; }

    public string? SSStatusCode { get; set; }

    public string? SSLog { get; set; }

    public DateTime? SSLastUpdateDateTime { get; set; }

    public virtual ServiceUnitBookingVerification ServiceUnitBookingVerification { get; set; } = null!;
}
