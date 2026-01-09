using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class tmp_ron_appusergroupprogram
{
    public string? UserGroupID { get; set; }

    public string? ProgramID { get; set; }

    public bool? IsUserGroupAddAble { get; set; }

    public bool? IsUserGroupEditAble { get; set; }

    public bool? IsUserGroupDeleteAble { get; set; }

    public bool? IsUserGroupApprovalAble { get; set; }

    public bool? IsUserGroupUnApprovalAble { get; set; }

    public bool? IsUserGroupVoidAble { get; set; }

    public bool? IsUserGroupUnVoidAble { get; set; }

    public bool? IsUserGroupExportAble { get; set; }
}
