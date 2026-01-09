using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Pio
{
    public int PioNo { get; set; }

    public DateTime? PioDateTime { get; set; }

    public string? QuestionerName { get; set; }

    public string? SROccupation { get; set; }

    public string? Question { get; set; }

    public string? Information { get; set; }

    public string? OtherSources { get; set; }

    public string? OtherCategory { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
