using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeLanguageProficiency
{
    public int EmployeeLanguageProficiencyID { get; set; }

    public int PersonID { get; set; }

    public DateTime EvaluationDate { get; set; }

    public string SRLanguage { get; set; } = null!;

    public string SRConversation { get; set; } = null!;

    public string SRTranslation { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
