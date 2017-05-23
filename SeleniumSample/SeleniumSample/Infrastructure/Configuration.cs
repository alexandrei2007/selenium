using System.Configuration;

namespace SeleniumSample.Infrastructure
{
    public static class Configuration
    {

        public static string SITE_URL
        {
            get
            {
                return ConfigurationManager.AppSettings["SITE_URL"];
            }
        }

        public static string BROWSER
        {
            get
            {
                return ConfigurationManager.AppSettings["BROWSER"];
            }
        }
    }
}
