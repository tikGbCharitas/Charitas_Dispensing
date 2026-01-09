using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalImage
{
    public int PersonID { get; set; }

    public byte[]? Photo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
