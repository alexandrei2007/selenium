using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumSample.Infrastructure
{
    public abstract class BaseClass
    {
        protected IWebDriver driver;

        [SetUp]
        public virtual void SetUp()
        {
            this.driver = DriverFactory.GetInstance();
        }

        [TearDown]
        public virtual void TearDown()
        {
            driver.Quit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public WebDriverWait Wait(int seconds)
        {
            return driver.Wait(seconds);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static Func<IWebDriver, ReadOnlyCollection<IWebElement>> IsVisible(IWebElement element)
        {
            return DriverExtensions.IsVisible(element);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static Func<IWebDriver, ReadOnlyCollection<IWebElement>> IsAllVisible(IList<IWebElement> elements)
        {
            return DriverExtensions.IsAllVisible(elements);
        }
    }
}
