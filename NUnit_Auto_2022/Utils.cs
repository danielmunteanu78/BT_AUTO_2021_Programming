using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
   public class Utils
    {
        public static IWebElement WaitForElement(IWebDriver driver, int seconds, By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }
        public static IWebElement WaitForFluentElement(IWebDriver driver, int seconds, By locator)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);           
            fluentWait.Timeout = TimeSpan.FromSeconds(seconds);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.Message = "Sorry ! The element in the page cannot be found !";
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            var element = fluentWait.Until(x => x.FindElement(locator));
            return element.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }    
    }
}
