using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NursingTransHD
{
    public string TransactionNo { get; set; } = null!;

    public DateTime NursingTransDateTime { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
