using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CostCalculationTemp
{
    public string RegistrationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal PatientAmount { get; set; }

    public decimal GuarantorAmount { get; set; }

    public decimal DiscountAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? ParamedicAmount { get; set; }

    public decimal? ParamedicFeeAmount { get; set; }

    public string? ParamedicFeePaymentNo { get; set; }

    public bool? IsPackage { get; set; }

    public string? ParentNo { get; set; }

    public string? IntermBillNo { get; set; }

    public bool? IsChecked { get; set; }

    public decimal? DiscountAmount2 { get; set; }

    public DateTime? InsertDateTime { get; set; }
}
