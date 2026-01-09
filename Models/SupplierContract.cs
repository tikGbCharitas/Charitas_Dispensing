using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SupplierContract
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string SupplierID { get; set; } = null!;

    public string ContractNo { get; set; } = null!;

    public DateTime ContractStart { get; set; }

    public DateTime ContractEnd { get; set; }

    public string ContractSummary { get; set; } = null!;

    public decimal ContractAmount { get; set; }

    public decimal PurchaseAmount { get; set; }

    public decimal DiscountAmount { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<SupplierContractItem> SupplierContractItems { get; set; } = new List<SupplierContractItem>();
}
