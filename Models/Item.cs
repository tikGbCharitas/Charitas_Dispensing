using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Item
{
    public string ItemID { get; set; } = null!;

    public string ItemGroupID { get; set; } = null!;

    public string SRItemType { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public bool IsActive { get; set; }

    public string Notes { get; set; } = null!;

    public string? ItemIDExternal { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRBillingGroup { get; set; }

    public string? ProductAccountID { get; set; }

    public bool? IsItemProduction { get; set; }

    public string? GuarantorID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public bool? IsHasTestResults { get; set; }

    public bool? IsNeedToBeSterilized { get; set; }

    public string? SRBridgingType { get; set; }

    public string? SRCssdItemGroup { get; set; }

    public string? SRBpjsItemGroup { get; set; }

    public string? SREBudgetCOA { get; set; }

    public virtual ItemDiagnostic? ItemDiagnostic { get; set; }

    public virtual ItemKitchen? ItemKitchen { get; set; }

    public virtual ItemLaboratory? ItemLaboratory { get; set; }

    public virtual ItemOptic? ItemOptic { get; set; }

    public virtual ItemProductMedic? ItemProductMedic { get; set; }

    public virtual ItemProductNonMedic? ItemProductNonMedic { get; set; }

    public virtual ItemRadiology? ItemRadiology { get; set; }

    public virtual ItemService? ItemService { get; set; }
}
