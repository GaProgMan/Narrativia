using Microsoft.Extensions.Configuration;

namespace Narrativia.Repository
{
    public class DatabaseConfiguration : ConfigurationBase
    {
        private string DataConnectionKey = "narrativiaDataConnection";

        private string AuthConnectionKey = "narrativiaAuthConnection";

        public string GetDataConnectionString()
        {
            return GetConfiguration().GetConnectionString(DataConnectionKey);
        }
        
        public string GetAuthConnectionString()
        {
            return GetConfiguration().GetConnectionString(AuthConnectionKey);
        }
    }
}