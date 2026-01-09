using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeLoan
{
    public int EmployeeLoanID { get; set; }

    public int PersonID { get; set; }

    public DateTime LoanDate { get; set; }

    public decimal Amount { get; set; }

    public decimal? LoanAmountWithInterest { get; set; }

    public decimal? PercentRateOfInterest { get; set; }

    public bool? FlatRate { get; set; }

    public string SRPurposeOfLoan { get; set; } = null!;

    public int? NumberOfInstallment { get; set; }

    public decimal? AmountOfInstallment { get; set; }

    public string SRHRPaymentMethod { get; set; } = null!;

    public int StartPaymentPeriode { get; set; }

    public int SalaryCodeInstallment { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public int? LoanNo { get; set; }

    public decimal? CoverageAmount { get; set; }

    public int? CompanyLaborProfileID { get; set; }

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? InstallmentMethod { get; set; }
}
