using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TestResultTemplate
{
    public long TestResultTemplateID { get; set; }

    public string ItemID { get; set; } = null!;

    public string? ParamedicID { get; set; }

    public string TestResultTemplateName { get; set; } = null!;

    public string? TestResult { get; set; }

    public string? TestSummary { get; set; }

    public string? TestSuggest { get; set; }

    public string? TestResultOtherLang { get; set; }

    public string? TestSummaryOtherLang { get; set; }

    public string? TestSuggestOtherLang { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
