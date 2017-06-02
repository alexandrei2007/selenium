using NUnit.Framework;
using SeleniumSample.Infrastructure;
using System.Drawing;

namespace SeleniumSample
{
    [TestFixture]
    public class ScreenshotTests : BaseClass
    {
        [Test]
        public void TakeScreenshot()
        {
            driver.Manage().Window.Size = new Size(1920, 1080);
            driver.Navigate().GoToUrl("https://www.google.com");

            using (var screenshot = driver.GetFullScreenshot())
            {
                screenshot.Save(@"screenshot-google.png", System.Drawing.Imaging.ImageFormat.Png);
            }

            driver.Navigate().GoToUrl("https://www.microsoft.com");

            using (var screenshot = driver.GetFullScreenshot())
            {
                screenshot.Save(@"screenshot-microsoft.png", System.Drawing.Imaging.ImageFormat.Png);
            }

            driver.Navigate().GoToUrl("https://www.apple.com");

            using (var screenshot = driver.GetFullScreenshot())
            {
                screenshot.Save(@"screenshot-apple.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

    }
}
