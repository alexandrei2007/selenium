using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumSample.Infrastructure
{
    public static class DriverExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static WebDriverWait Wait(this IWebDriver driver, int seconds)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static Func<IWebDriver, ReadOnlyCollection<IWebElement>> IsVisible(IWebElement element)
        {
            return ExpectedConditions.VisibilityOfAllElementsLocatedBy(new ReadOnlyCollection<IWebElement>(
                new List<IWebElement>() { element }));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static Func<IWebDriver, ReadOnlyCollection<IWebElement>> IsAllVisible(IList<IWebElement> elements)
        {
            return ExpectedConditions.VisibilityOfAllElementsLocatedBy(new ReadOnlyCollection<IWebElement>(
                elements));
        }
    }
}
