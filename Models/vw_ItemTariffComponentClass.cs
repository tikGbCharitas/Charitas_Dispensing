using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_ItemTariffComponentClass
{
    public string ItemID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public string TariffComponentName { get; set; } = null!;
}
