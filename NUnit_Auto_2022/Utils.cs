using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnit_Auto_2022
{
   public class Utils
    {
        public static IEnumerable<Cookie> AllCookies { get; private set; }

        public static IWebElement WaitForElement(IWebDriver driver, int seconds, By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }
       public static IWebElement WaitForFluentElement(IWebDriver driver, int seconds, By locator)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(seconds),
                PollingInterval = TimeSpan.FromMilliseconds(250),
                Message = "Sorry ! The element in the page cannot be found !"
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return fluentWait.Until(x => x.FindElement(locator));            
        }

        public static void PrintCookies(ICookieJar cookies)
        {
            foreach (Cookie c in cookies.AllCookies)
            {
                Console.WriteLine("Cookie name {0} cookie value {1}", c.Name, c.Value);
            }
        }

        public static void TakeScreenShotWithDate(IWebDriver driver, string path, string fileName, ScreenshotImageFormat format)
        {
            DirectoryInfo validaotion = new DirectoryInfo(path);
            if (!validaotion.Exists)
            {
                validaotion.Create();
            }

            string currentDate = DateTime.Now.ToString();
            StringBuilder sb = new StringBuilder(currentDate);
            sb.Replace(":", "_");
            sb.Replace(" ", "_");
            sb.Replace(".", "_");

            string finalFilePath = String.Format("{0}\\{1}.{2}",path,fileName,currentDate, format);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(finalFilePath,format);
        }
    }
}
