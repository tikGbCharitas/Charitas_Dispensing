using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProductAccount
{
    public string ProductAccountID { get; set; } = null!;

    public string ProductAccountName { get; set; } = null!;

    public bool IsActive { get; set; }

    public int? ChartOfAccountIdIncome { get; set; }

    public int? SubledgerIdIncome { get; set; }

    public int? ChartOfAccountIdInventory { get; set; }

    public int? SubledgerIdInventory { get; set; }

    public int? ChartOfAccountIdCOGS { get; set; }

    public int? SubledgerIdCOGS { get; set; }

    public int? ChartOfAccountIdSalesReturn { get; set; }

    public int? SubledgerIdSalesReturn { get; set; }

    public int? ChartOfAccountIdPurchaseReturn { get; set; }

    public int? SubledgerIdPurchaseReturn { get; set; }

    public int? ChartOfAccountIdAcrual { get; set; }

    public int? SubledgerIdAcrual { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public int? ChartOfAccountIdCost { get; set; }

    public int? SubledgerIdCost { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? ChartOfAccountIdIncomeIP { get; set; }

    public int? SubledgerIdIncomeIP { get; set; }

    public int? ChartOfAccountIdInventoryIP { get; set; }

    public int? SubledgerIdInventoryIP { get; set; }

    public int? ChartOfAccountIdCOGSIP { get; set; }

    public int? SubledgerIdCOGSIP { get; set; }

    public int? ChartOfAccountIdSalesReturnIP { get; set; }

    public int? SubledgerIdSalesReturnIP { get; set; }

    public int? ChartOfAccountIdPurchaseReturnIP { get; set; }

    public int? SubledgerIdPurchaseReturnIP { get; set; }

    public int? ChartOfAccountIdAcrualIP { get; set; }

    public int? SubledgerIdAcrualIP { get; set; }

    public int? ChartOfAccountIdDiscountIP { get; set; }

    public int? SubledgerIdDiscountIP { get; set; }

    public int? ChartOfAccountIdCostIP { get; set; }

    public int? SubledgerIdCostIP { get; set; }

    public int? ChartOfAccountIdIncomeIGD { get; set; }

    public int? SubledgerIdIncomeIGD { get; set; }

    public int? ChartOfAccountIdInventoryIGD { get; set; }

    public int? SubledgerIdInventoryIGD { get; set; }

    public int? ChartOfAccountIdCOGSIGD { get; set; }

    public int? SubledgerIdCOGSIGD { get; set; }

    public int? ChartOfAccountIdSalesReturnIGD { get; set; }

    public int? SubledgerIdSalesReturnIGD { get; set; }

    public int? ChartOfAccountIdPurchaseReturnIGD { get; set; }

    public int? SubledgerIdPurchaseReturnIGD { get; set; }

    public int? ChartOfAccountIdAcrualIGD { get; set; }

    public int? SubledgerIdAcrualIGD { get; set; }

    public int? ChartOfAccountIdDiscountIGD { get; set; }

    public int? SubledgerIdDiscountIGD { get; set; }

    public int? ChartOfAccountIdCostIGD { get; set; }

    public int? SubledgerIdCostIGD { get; set; }

    public string? SRItemType { get; set; }
}
