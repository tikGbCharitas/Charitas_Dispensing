using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BPJSSepLog
{
    public long IDLog { get; set; }

    public DateTime Tanggal { get; set; }

    public string? Request { get; set; }

    public string? Respon { get; set; }
}
