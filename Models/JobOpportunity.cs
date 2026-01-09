using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class JobOpportunity
{
    public int JobOpportunityID { get; set; }

    public string JobContent { get; set; } = null!;

    public DateTime DatePrepared { get; set; }

    public DateTime LastDateAccept { get; set; }

    public string ContactPerson { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
