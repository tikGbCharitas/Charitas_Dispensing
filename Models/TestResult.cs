using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TestResult
{
    public string TransactionNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string? ParamedicID { get; set; }

    public DateTime? TestResultDateTime { get; set; }

    public string? TestResult1 { get; set; }

    public string? TestSummary { get; set; }

    public string? TestSuggest { get; set; }

    public string? TestResultOtherLang { get; set; }

    public string? TestSummaryOtherLang { get; set; }

    public string? TestSuggestOtherLang { get; set; }

    public string? TestResultHistory { get; set; }

    public string? TestSummaryHistory { get; set; }

    public string? TestSuggestHistory { get; set; }

    public string? TestResultOtherLangHistory { get; set; }

    public string? TestSummaryOtherLangHistory { get; set; }

    public string? TestSuggestOtherLangHistory { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ClinicalInfo { get; set; }

    public DateTime? FinalResultDateTime { get; set; }

    public DateTime? ReceivedDateTime { get; set; }

    public string? ReceivedBy { get; set; }

    public string? ReceivedPhone { get; set; }

    public string? DeliveredBy { get; set; }

    public bool? IsFinalResult { get; set; }

    public bool? IsExamination { get; set; }

    public DateTime? ExaminationDateTime { get; set; }
}
