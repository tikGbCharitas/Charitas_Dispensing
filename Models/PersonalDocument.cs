using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalDocument
{
    public long PersonalDocumentID { get; set; }

    public int PersonID { get; set; }

    public string FileAttachName { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public DateTime? DocumentDate { get; set; }

    public string? Notes { get; set; }

    public byte[]? SmallImage { get; set; }

    public string? OriFileName { get; set; }

    public string? OriPath { get; set; }

    public bool? IsUpload { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? DocumentCode { get; set; }

    public int? RefferenceID { get; set; }
}
