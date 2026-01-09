using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionTemplate
{
    public string TemplateNo { get; set; } = null!;

    public string TemplateName { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public DateTime LastCreateDateTime { get; set; }

    public string LastCreateUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
