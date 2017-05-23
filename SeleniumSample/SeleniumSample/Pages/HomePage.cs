using OpenQA.Selenium;

namespace SeleniumSample.Pages
{
    public class HomePage : BasePage
    {
        #region Ctor

        public HomePage(IWebDriver driver) : base(driver)
        {
            EmailTextFieldLocator = By.XPath("//form//input[@name='Email']");
            EmailErrorMessageLocator = By.XPath("//form//span[@data-valmsg-for='Email']");
            PasswordTextFieldLocator = By.XPath("//form//input[@name='Password']");
            PasswordErrorMessageLocator = By.XPath("//form//span[@data-valmsg-for='Password']");
            SubmitButtonLocator = By.XPath("//form//input[@type='submit']");
        }

        #endregion

        #region Properties

        public By EmailTextFieldLocator { get; set; }
        public IWebElement EmailTextField
        {
            get
            {
                return driver.FindElement(EmailTextFieldLocator);
            }
        }
        public By EmailErrorMessageLocator { get; set; }
        public IWebElement EmailErrorMessage
        {
            get
            {
                return driver.FindElement(EmailErrorMessageLocator);
            }
        }
        public By PasswordTextFieldLocator { get; set; }
        public IWebElement PasswordTextField
        {
            get
            {
                return driver.FindElement(PasswordTextFieldLocator);
            }
        }
        public By PasswordErrorMessageLocator { get; set; }
        public IWebElement PasswordErrorMessage
        {
            get
            {
                return driver.FindElement(PasswordErrorMessageLocator);
            }
        }
        public By SubmitButtonLocator { get; set; }
        public IWebElement SubmitButton
        {
            get
            {
                return driver.FindElement(SubmitButtonLocator);
            }
        }

        #endregion

        #region Methods

        public void Send()
        {
            //SubmitButton.Click();
            SubmitButton.SendKeys(Keys.Enter);
        }

        #endregion
    }
}
