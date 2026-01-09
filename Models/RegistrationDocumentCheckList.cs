using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationDocumentCheckList
{
    public string RegistrationNo { get; set; } = null!;

    public int DocumentDefinitionID { get; set; }

    public int DocumentFilesID { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public virtual DocumentDefinition DocumentDefinition { get; set; } = null!;

    public virtual DocumentFile DocumentFiles { get; set; } = null!;

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
