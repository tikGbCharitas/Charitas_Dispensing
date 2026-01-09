using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OperationNotesTemplate
{
    public int TemplateID { get; set; }

    public string? ParamedicID { get; set; }

    public string? TemplateName { get; set; }

    public string? TemplateText { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
