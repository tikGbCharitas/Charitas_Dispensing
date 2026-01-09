using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class IntermBill
{
    public string IntermBillNo { get; set; } = null!;

    public DateTime IntermBillDate { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal PatientAmount { get; set; }

    public decimal GuarantorAmount { get; set; }

    public bool IsApproved { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? AskesCoveredSeqNo { get; set; }

    public string JournalIncomePaymentNo { get; set; } = null!;

    public decimal? AdministrationAmount { get; set; }

    public decimal? GuarantorAdministrationAmount { get; set; }

    public decimal? DiscAdmPatient { get; set; }

    public decimal? DiscAdmGuarantor { get; set; }

    public decimal? DiscPatientAmount { get; set; }

    public decimal? DiscGuarantorAmount { get; set; }
}
