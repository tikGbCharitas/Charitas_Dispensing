using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class UserProgramLog
{
    public long UserProgramLogID { get; set; }

    public long UserLogID { get; set; }

    public string ProgramID { get; set; } = null!;

    public DateTime AccessDateTime { get; set; }

    public string? Parameter { get; set; }
}
