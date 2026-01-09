using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalContact
{
    public int PersonalContactID { get; set; }

    public int PersonID { get; set; }

    public string SRContactType { get; set; } = null!;

    public string ContactValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
