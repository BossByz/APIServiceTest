using Microsoft.Extensions.Configuration;

namespace APIServiceTest.Managers
{
    public class ConfigurationManager
    {
        public static IConfiguration Configuration { get; private set; }
        public ConfigurationManager(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
