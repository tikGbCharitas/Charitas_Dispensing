using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace AvicennaDispensing.Helpers
{
    public static class ClaimTypesCustom
    {
        public const string UserID = "UserID";
        public const string UserName = "UserName";
        public const string Role = "Role";
        public const string Service_Unit = "Service_Unit";
        public const string CRUD = "CRUD";
        public const string Export = "Export";
    }
}
