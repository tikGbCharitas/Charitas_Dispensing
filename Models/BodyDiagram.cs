using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BodyDiagram
{
    public string BodyID { get; set; } = null!;

    public string? BodyName { get; set; }

    public string? Description { get; set; }

    public byte[]? BodyImage { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
