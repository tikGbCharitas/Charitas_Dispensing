using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DocumentDefinitionItem
{
    public int DocumentDefinitionID { get; set; }

    public int DocumentFilesID { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
