using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class VitalSign
{
    public string VitalSignID { get; set; } = null!;

    public string VitalSignName { get; set; } = null!;

    public string? VitalSignInitial { get; set; }

    public string? SRVitalSignGroup { get; set; }

    public int? RowIndexInGroup { get; set; }

    public string? ValueType { get; set; }

    public string? StandardReferenceID { get; set; }

    public string? EntryMask { get; set; }

    public string? VitalSignUnit { get; set; }

    public string? NumType { get; set; }

    public int? NumDecimalDigits { get; set; }

    public int? NumMinValue { get; set; }

    public int? NumMaxValue { get; set; }

    public int? NumMaxLength { get; set; }

    public bool? IsMonitoring { get; set; }

    public bool? IsChart { get; set; }

    public int? ChartColor { get; set; }

    public int? ChartMinValue { get; set; }

    public int? ChartMaxValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    /// <summary>
    /// Untuk keperluan import data dari PHR
    /// </summary>
    public string? QuestionID { get; set; }

    public string? ParentVitalSignID { get; set; }
}
