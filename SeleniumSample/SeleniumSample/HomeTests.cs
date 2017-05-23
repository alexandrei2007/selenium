using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumSample.Infrastructure;
using SeleniumSample.Pages;

namespace SeleniumSample
{
    [TestFixture]
    public class HomeTests : BaseClass
    {
        [Test]
        public void Login_submit_success()
        {
            driver.Navigate().GoToUrl(Configuration.SITE_URL);

            var page = new HomePage(this.driver);
            page.EmailTextField.SendKeys("account@email.com");
            page.PasswordTextField.SendKeys("123456");
            page.Send();

            Wait(10).Until(ExpectedConditions.UrlMatches(Configuration.SITE_URL + "home/success"));
        }

        [Test]
        public void Login_submit_check_email_validation()
        {
            driver.Navigate().GoToUrl(Configuration.SITE_URL);

            var page = new HomePage(this.driver);
            page.Send();

            Wait(10).Until(ExpectedConditions.ElementIsVisible(page.EmailErrorMessageLocator));

            page.EmailTextField.SendKeys("account@email.com");
            page.Send();

            Wait(10).Until(ExpectedConditions.InvisibilityOfElementLocated(page.EmailErrorMessageLocator));
        }

        [Test]
        public void Login_submit_check_password_validation()
        {
            driver.Navigate().GoToUrl(Configuration.SITE_URL);

            var page = new HomePage(this.driver);
            page.Send();

            Wait(10).Until(ExpectedConditions.ElementIsVisible(page.PasswordErrorMessageLocator));

            page.PasswordTextField.SendKeys("123456");
            page.Send();

            Wait(10).Until(ExpectedConditions.InvisibilityOfElementLocated(page.PasswordErrorMessageLocator));
        }
    }
}
