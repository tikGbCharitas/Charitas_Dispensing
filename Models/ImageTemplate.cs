using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ImageTemplate
{
    public string ImageTemplateID { get; set; } = null!;

    public string? ImageTemplateName { get; set; }

    public string? SRImageTemplateType { get; set; }

    public string? Description { get; set; }

    public byte[]? Image { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
