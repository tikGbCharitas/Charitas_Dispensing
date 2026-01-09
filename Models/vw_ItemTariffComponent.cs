using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_ItemTariffComponent
{
    public string ItemID { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public string TariffComponentName { get; set; } = null!;
}
