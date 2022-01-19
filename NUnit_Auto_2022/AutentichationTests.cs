﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022
{
    class AutentichationTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "49990";
        const string path = "/#/login";
        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [TestCase("dinosaur", "dinosaurpassword", "", "")]
        [TestCase("dinosaur", "", "", "Password is required !")]
        [TestCase("", "","Username is required!", "Password is required!")]
        [TestCase("", "dinopass", "Username is required!", "")]

        public void Test01(string user, string pass, string userErr, string passErr)
        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.CssSelector(""));
            Assert.AreEqual("Authentication", pageText.Text);

            var loginLink = driver.FindElement(By.CssSelector(""));
            loginLink.Click();

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.Id("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector(""));
            var passwordError = driver.FindElement(By.CssSelector(""));

            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

            Assert.Equals(userErr, usernameError.Text);
            Assert.Equals(passErr, passwordError.Text);
        }
        [Test]
        public void Test02()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button1 = driver.FindElement(By.Id("btn1"));
            button1.Click();
        }

        // explicit wait test
        [Test]
        public void Test03()
        {

            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            //var button1 = driver.FindElement(By.Id("btn1"));
            var button1 = Utils.WaitForElement(driver, 20, By.Id("btn1"));
            button1.Click();
        }

        [Test]
        public void Test04()
        {

            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            //var button1 = driver.FindElement(By.Id("btn1"));
            var button2 = Utils.WaitForElement(driver, 20, By.Id("btn2"));
            for(int i=0; i < 100; i++)
            {
                button2.Click();
            }
            Thread.Sleep(20000); // pausing test execution for 20 seconds !!! PLEASE AVOID !!!
        }

        [Test]
        public void Test05()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var element = Utils.WaitForFluentElement(driver, 20, By.Id("btn2"));
            element.Click();
        }

        [TearDown]
                public void CleanUp()
        {
            driver.Quit();
        }

    }
}
