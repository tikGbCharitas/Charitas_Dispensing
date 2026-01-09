using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ClinicalExamResult
{
    public string RegistrationNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Result { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
