using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemLaboratoryDetail
{
    public string ItemID { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string? Sex { get; set; }

    public string? SRAgeUnit { get; set; }

    public decimal? AgeMin { get; set; }

    public decimal? AgeMax { get; set; }

    public string? SRAnswerType { get; set; }

    public string? NormalValueMin { get; set; }

    public string? NormalValueMax { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public decimal? TotalAgeMin { get; set; }

    public decimal? TotalAgeMax { get; set; }

    public string? Notes { get; set; }

    public string? AnswerTypeReferenceID { get; set; }
}
