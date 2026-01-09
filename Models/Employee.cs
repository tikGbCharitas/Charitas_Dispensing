using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Employee
{
    public string EmployeeID { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;

    public string? ShortName { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string? SREmployeeStatus { get; set; }

    public string? SRGenderType { get; set; }

    public string? DepartmentID { get; set; }

    public string? JobTitle { get; set; }

    public DateTime? PermanentDate { get; set; }

    public string? ContractNumber { get; set; }

    public DateTime? ContractStartDate { get; set; }

    public DateTime? ContractEndDate { get; set; }

    public string? TaxRegistrationNo { get; set; }

    public string? JamsostekNo { get; set; }

    public string? StreetName { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? ZipCode { get; set; }

    public string? PhoneNo { get; set; }

    public string? MobilePhoneNo { get; set; }

    public string? Email { get; set; }

    public DateTime? BornDate { get; set; }

    public string? BornPlace { get; set; }

    public string? EmployeeNotes { get; set; }

    public DateTime? ResignDate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
