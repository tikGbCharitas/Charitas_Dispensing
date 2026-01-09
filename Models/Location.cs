using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Location
{
    public string LocationID { get; set; } = null!;

    public string LocationName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string? ParentID { get; set; }

    public string ItemGroupID { get; set; } = null!;

    public string? PermitID { get; set; }

    public bool IsHeader { get; set; }

    public bool IsHoldForTransaction { get; set; }

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

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? ChartOfAccountIdAcrual { get; set; }

    public int? SubledgerIdAcrual { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public int? ChartOfAccountIdCost { get; set; }

    public int? SubledgerIdCost { get; set; }

    public string? SRTypeOfInventory { get; set; }

    public bool? IsAllowedToStockGoods { get; set; }

    public bool? IsConsignment { get; set; }

    public bool? IsValidateMaxValueOnDistReqForIpm { get; set; }

    public bool? IsValidateMaxValueOnDistReqForIpnm { get; set; }

    public bool? IsValidateMaxValueOnDistReqForIk { get; set; }

    public DateTime? LastHoldForTransactionDateTime { get; set; }

    public string? LastHoldForTransactionByUserID { get; set; }

    public string? SRStockGroup { get; set; }

    public bool? IsAutoUpdateStockMinMax { get; set; }
}
