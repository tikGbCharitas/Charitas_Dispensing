using System.Reflection;

namespace AvicennaDispensing.Helpers
{
    public class ProgramSettings
    {
        public string TargetProgramId { get; set; } = null!;
    }
    public static class VersionHelper
    {
        public static string GetAppVersion()
        {
            var assembly = Assembly.GetEntryAssembly();
            return assembly?
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                .InformationalVersion ?? "-";
        }
    }
}
