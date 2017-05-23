using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumSample.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
    }
}
