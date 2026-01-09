using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DocumentDefinition
{
    public int DocumentDefinitionID { get; set; }

    public string DepartmentID { get; set; } = null!;

    public string SRFilesAnalysis { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public virtual ICollection<RegistrationDocumentCheckList> RegistrationDocumentCheckLists { get; set; } = new List<RegistrationDocumentCheckList>();
}
