using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalBenefitClaim
{
    public int MedicalBenefitClaimID { get; set; }

    public int PersonID { get; set; }

    public DateTime ClaimDate { get; set; }

    public int MedicalBenefitInfoID { get; set; }

    public int YearPeriodID { get; set; }

    public DateTime? SettlementDate { get; set; }

    public bool IsApproved { get; set; }

    public decimal TotalAmountOnBill { get; set; }

    public decimal TotalReimbursementAmount { get; set; }

    public decimal TotalNonReimbursementAmount { get; set; }

    public decimal TotalApprovedAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
