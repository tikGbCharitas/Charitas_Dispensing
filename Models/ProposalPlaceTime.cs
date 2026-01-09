using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProposalPlaceTime
{
    public int SequenceNo { get; set; }

    public string ProposalID { get; set; } = null!;

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public string? Place { get; set; }

    public string? SREbudgetProposalMethod { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
