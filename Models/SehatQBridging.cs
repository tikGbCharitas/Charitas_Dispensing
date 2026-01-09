using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SehatQBridging
{
    public int Id { get; set; }

    public string? APIType { get; set; }

    public string? APIDesc { get; set; }

    public string? AppointmentNo { get; set; }

    public string? RegistrationNo { get; set; }

    public string? SQTransactionID { get; set; }

    public string? SQPatientCardNo { get; set; }

    public string? SQBenefitCode { get; set; }

    public string? ClaimNo { get; set; }

    public string? RawData { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public DateOnly? SQRegistrationDate { get; set; }

    public bool? IsVoid { get; set; }

    public string? SehatQBridgingReferenceID { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
