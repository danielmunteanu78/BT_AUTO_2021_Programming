using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class CookieTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/cookie";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void Test01()
        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(5)"));
            Assert.AreEqual("Cookie", pageText.Text);

            var setcookie = driver.FindElement(By.Id("set-cookie"));
            var removecookie = driver.FindElement(By.Id("delete-cookie"));
            var cookievalue = driver.FindElement(By.Id("cookie-value"));
            var cookies = driver.Manage().Cookies;

            setcookie.Click();

            Console.WriteLine("Cookie value: {0} ", cookievalue.Text);
            var ck = cookies.GetCookieNamed("gibberish");
            Assert.AreEqual(cookievalue.Text, ck.Value);
            Utils.PrintCookies(cookies);

            removecookie.Click();
            Console.WriteLine("Cookies after remove operation: {0}", cookievalue.Text);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
