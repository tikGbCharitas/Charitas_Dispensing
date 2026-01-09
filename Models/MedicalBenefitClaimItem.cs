using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalBenefitClaimItem
{
    public int MedicalBenefitClaimItemID { get; set; }

    public int MedicalBenefitClaimID { get; set; }

    public int TreatedID { get; set; }

    public string? ReceiptNo { get; set; }

    public DateTime? TreatmentDate { get; set; }

    public string? VisitTypeID { get; set; }

    public string? PhysicianName { get; set; }

    public int? HospitalInfoID { get; set; }

    public bool? IsOccupationalInjury { get; set; }

    public decimal? AmountOnBill { get; set; }

    public decimal? ReAmount { get; set; }

    public decimal? ApprovedAmount { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
