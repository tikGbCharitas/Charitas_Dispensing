using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AdvertisedPersonnelRequisition
{
    public int AdvertisedPersonnelRequisitionID { get; set; }

    public int JobOpportunityID { get; set; }

    public int PersonnelRequisitionID { get; set; }

    public decimal EstimatedSalary { get; set; }

    public decimal MinimumEstimatedSalary { get; set; }

    public decimal MaximumEstimatedSalary { get; set; }

    public string? JobDescription { get; set; }

    public string? JobSpecification { get; set; }

    public string ContactPerson { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
