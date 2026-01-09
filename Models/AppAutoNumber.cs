using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppAutoNumber
{
    public string SRAutoNumber { get; set; } = null!;

    public DateTime EffectiveDate { get; set; }

    public string? Prefik { get; set; }

    public string? SeparatorAfterPrefik { get; set; }

    public bool? IsUsedDepartment { get; set; }

    public string? SeparatorAfterDept { get; set; }

    public bool? IsUsedYear { get; set; }

    public byte? YearDigit { get; set; }

    public string? SeparatorAfterYear { get; set; }

    public bool? IsUsedMonth { get; set; }

    public bool? IsMonthInRomawi { get; set; }

    public string? SeparatorAfterMonth { get; set; }

    public bool? IsUsedDay { get; set; }

    public string? SeparatorAfterDay { get; set; }

    public byte? NumberLength { get; set; }

    public byte? NumberGroupLength { get; set; }

    public string? NumberGroupSeparator { get; set; }

    public string? NumberFormat { get; set; }

    public string? SeparatorAfterNumber { get; set; }

    public bool? IsUsedYearToDateOrder { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
