using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialProcessDocumentUpload
{
    public long DocumentID { get; set; }

    public string TransactionNo { get; set; } = null!;

    public string FileAttachName { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public DateTime? DocumentDate { get; set; }

    public string? Notes { get; set; }

    public byte[]? SmallImage { get; set; }

    public string? OriFileName { get; set; }

    public string? OriPath { get; set; }

    public bool? IsUpload { get; set; }

    public bool? IsDeleted { get; set; }
}
