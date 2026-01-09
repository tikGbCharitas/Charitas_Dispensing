using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SehatQToken
{
    public int ID { get; set; }

    public string? Token { get; set; }

    public DateTime? CreateDateTime { get; set; }
}
