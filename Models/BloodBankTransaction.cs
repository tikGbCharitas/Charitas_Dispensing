using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BloodBankTransaction
{
    public string TransactionNo { get; set; } = null!;

    public DateTime? TransactionDate { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? RequestTime { get; set; }

    public string? BloodBankNo { get; set; }

    public string? PdutNo { get; set; }

    public string? RegistrationNo { get; set; }

    public string? SRBloodGroupRequest { get; set; }

    public short? QtyBagRequest { get; set; }

    public decimal? VolumeBag { get; set; }

    public string? Diagnose { get; set; }

    public string? Reason { get; set; }

    public string? OfficerByUserID { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
