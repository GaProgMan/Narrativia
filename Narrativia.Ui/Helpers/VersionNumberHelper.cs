using System.Reflection;

namespace Narrativia.Ui.Helpers
{
    public class VersionNumberHelper
    {
        public static string GetVersionNumber()
        {
            return Assembly.GetEntryAssembly()
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                .InformationalVersion;
        }
    }
}