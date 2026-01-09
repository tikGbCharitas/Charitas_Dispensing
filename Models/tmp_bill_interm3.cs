using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class tmp_bill_interm3
{
    public int? Ident { get; set; }

    public string? RegistrationNo { get; set; }

    public string? TransactionNo { get; set; }

    public string? ReferenceNo { get; set; }

    public string? NoUrut { get; set; }

    public string? SequenceNo { get; set; }

    public string? ReferenceSequenceNo { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? IntermbillNo { get; set; }

    public string? ItemID { get; set; }

    public string? ItemName { get; set; }

    public string? BillingGroupID { get; set; }

    public string? BillingGroupName { get; set; }

    public string? TariffComponentID { get; set; }

    public decimal? ChargeQuantity { get; set; }

    public string? SRItemUnit { get; set; }

    public decimal? PatientAmount { get; set; }

    public decimal? GuarantorAmount { get; set; }

    public decimal? PatientDiscountAmount { get; set; }

    public decimal? GuarantorDiscountAmount { get; set; }

    public decimal? CPrice { get; set; }

    public decimal? CDiscountAmount { get; set; }

    public string? ParamedicCollectionName { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? ClassID { get; set; }

    public int? ComponentCount { get; set; }

    public string? RRegistrationNo { get; set; }

    public string? SRItemType { get; set; }
}
