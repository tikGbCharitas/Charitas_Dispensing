using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TmpPresc
{
    public string? UserID { get; set; }

    public string? RegistrationNo { get; set; }

    public string? ItemGroupName { get; set; }

    public string? ItemIDDetail { get; set; }

    public string? Jenis { get; set; }

    public string? ItemName { get; set; }

    public string? IDGroup { get; set; }

    public string? NameBilling { get; set; }

    public string? ClassDt { get; set; }

    public string? ClassNameDt { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? SUName { get; set; }

    public string? SU { get; set; }

    public decimal? Price { get; set; }

    public decimal? ChargeQuantity { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? TotalPA { get; set; }

    public decimal? TotalGA { get; set; }

    public decimal? Total { get; set; }

    public string? PrescriptionNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceSequenceNo { get; set; }

    public string? ItemGroupID { get; set; }
}
