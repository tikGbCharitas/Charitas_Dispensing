using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NutritionCareDiagnoseTransDT
{
    public long ID { get; set; }

    public string TransactionNo { get; set; } = null!;

    public string TerminologyID { get; set; } = null!;

    public string? TerminologyName { get; set; }

    public string SRNutritionCareTerminologyLevel { get; set; } = null!;

    public string? TerminologyParentID { get; set; }

    public string TmpTerminologyID { get; set; } = null!;

    public string TmpTerminologyParentID { get; set; } = null!;

    public long? ParentID { get; set; }

    public string? ReferenceToPhrNo { get; set; }

    public string? S { get; set; }

    public string? O { get; set; }

    public string? D { get; set; }

    public string? I { get; set; }

    public string? ME { get; set; }

    public DateTime? ExecuteDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
