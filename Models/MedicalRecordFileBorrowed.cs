using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalRecordFileBorrowed
{
    public string TransactionNo { get; set; } = null!;

    public string PatientID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public DateTime DateOfBorrowing { get; set; }

    public DateTime? DateOfReturn { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? NameOfTheBorrower { get; set; }

    public string? SRForThePurposesOf { get; set; }

    public string? Notes { get; set; }

    public string? NameOfRecipientID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? NameOfGivenID { get; set; }

    public string? ReturnByName { get; set; }
}
