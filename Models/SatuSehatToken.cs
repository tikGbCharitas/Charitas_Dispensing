using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SatuSehatToken
{
    public int TokenID { get; set; }

    public string TokenValue { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public DateTime ExpiredDateTime { get; set; }
}
