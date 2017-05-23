using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Drawing;

namespace SeleniumSample.Infrastructure
{
    public class DriverFactory
    {
        protected const string MOBILE_USER_AGENT = "Mozilla/5.0 (iPhone; CPU iPhone OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5376e Safari/8536.25";

        public static IWebDriver GetInstance(bool mobile = false)
        {
            IWebDriver instance = null;

            if (Configuration.BROWSER == "chrome")
            {
                if (mobile)
                {
                    var options = new ChromeOptions();
                    options.AddArgument("--user-agent=" + MOBILE_USER_AGENT);
                    instance = new ChromeDriver(options);
                }
                else
                {
                    instance = new ChromeDriver();
                }
            }
            else if (Configuration.BROWSER == "firefox")
            {
                if (mobile)
                {
                    var profile = new FirefoxProfile();
                    profile.SetPreference("general.useragent.override", MOBILE_USER_AGENT);
                    instance = new FirefoxDriver(profile);
                }
                else
                {
                    instance = new FirefoxDriver();
                }

            }
            else if (Configuration.BROWSER == "ie")
            {
                if (mobile)
                {
                    throw new NotImplementedException();
                }

                var options = new InternetExplorerOptions();
                options.IgnoreZoomLevel = true;
                instance = new InternetExplorerDriver(options);
            }

            if (mobile)
            {
                instance.Manage().Window.Size = new Size(375, 667);
            }

            return instance;
        }
    }
}
