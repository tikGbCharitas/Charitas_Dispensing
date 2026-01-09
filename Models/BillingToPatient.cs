using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BillingToPatient
{
    public string BillingNo { get; set; } = null!;

    public DateTime BillingCreatedDateTime { get; set; }

    public string BillingCreatedByUserID { get; set; } = null!;

    public DateTime? BillingDate { get; set; }

    public string? SRBillingType { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string? ServiceUnitID { get; set; }

    public string? RoomID { get; set; }

    public string? BedID { get; set; }

    public string? ClassID { get; set; }

    public string? ChargeClassID { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? TransactionAmount { get; set; }

    public decimal? DownPaymentAmount { get; set; }

    public decimal? PlafondAmount { get; set; }

    public decimal? RemainingAmount { get; set; }

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public decimal? PaymentAmount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
