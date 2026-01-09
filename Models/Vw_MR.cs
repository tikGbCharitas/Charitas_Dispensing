using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Vw_MR
{
    public string? MedicalNo { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    public string StreetName { get; set; } = null!;

    public string Kd_Kecamatan { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string CityOfBirth { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string Jns_Kelamin { get; set; } = null!;

    public string Status_Nikah { get; set; } = null!;

    public string Warganegara { get; set; } = null!;

    public string Agama { get; set; } = null!;

    public string Gol_Darah { get; set; } = null!;

    public string Suku { get; set; } = null!;

    public string Pendidikan { get; set; } = null!;

    public string Pekerjaan { get; set; } = null!;

    public string Mr_Saudara { get; set; } = null!;

    public string Hub_Saudara { get; set; } = null!;

    public string User_ID { get; set; } = null!;

    public string? LastUpdateByUserID { get; set; }
}
