using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SehatQLog
{
    public int Id { get; set; }

    public string? LogDesc { get; set; }

    public string? LogType { get; set; }

    public string? LogStatus { get; set; }

    public string? RawData { get; set; }

    public string? ReferenceNotes { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
