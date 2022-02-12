using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class RegistrationTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/registration";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestCase("DanielSan", "", "12345678", "", "12345678", "", "Daniel", "", "Munteanu", "", "daniel.munteanu@yahoo.com", "", "24/07/1978", "Romanian")]
        [TestCase("Dan", "Minimum of 4 characters is required!", "12345678", "", "12345678", "", "Daniel", "", "Munteanu", "", "daniel.munteanu@yahoo.com", "", "24/07/1978", "Romanian")]
        [TestCase("DanielSan", "", "", "Password is required!", "123456", "Passwords do not match!", "Daniel", "", "Munteanu", "", "daniel.munteanu@yahoo.com", "", "24/07/1978", "Romanian")]
        [TestCase("DanielSan", "", "123456", "Minimum of 8 characters is required!", "123456", "", "Daniel", "", "Munteanu", "", "daniel.munteanu@yahoo.com", "", "24/07/1978", "Romanian")]
        [TestCase("DanielSan", "", "123456789", "", "12345678", "Passwords do not match!", "Daniel", "", "Munteanu", "", "daniel.munteanu@yahoo.com", "", "24/07/1978", "Romanian")]
        [TestCase("DanielSan", "", "12345678", "", "12345678", "", "D", "Minimum of 2 characters is required!", "M", "Minimum of 2 characters is required!", "daniel.munteanu@yahoo.com", "", "24/07/1978", "Romanian")]
        [TestCase("DanielSan", "", "12345678", "", "12345678", "", "Daniel", "", "Munteanu", "", "", "Email is required!", "24/07/1978", "Romanian")]
        [TestCase("DanielSan", "", "12345678", "", "12345678", "", "Daniel", "", "Munteanu", "", "daniel.munteanu@yahoo", "Invalid email address!", "24/07/1978", "Romanian")]
        [TestCase("Dan", "Minimum of 4 characters is required!", "123456", "Minimum of 8 characters is required!", "12345678", "Passwords do not match!", "Daniel", "", "Munteanu", "", "daniel.munteanu@ya", "Invalid email address!", "24/07/1978", "Romanian")]
        [TestCase("DanielSan", "", "12345678", "", "12345678", "", "Daniel", "", "Munteanu", "", "daniel.munteanu@yahoo.com", "", "", "")]




        public void Test01(string user, string userErr, string pass, string passErr, string confpass, string confpassErr, string fname, string fnameErr, string lname, string lnameErr, string mail, string mailErr, string dob, string nation)
        {

            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Registration", pageText.Text);

            var username = driver.FindElement(By.Id("input-username"));
            var password = driver.FindElement(By.Id("input-password"));
            var confpassword = driver.FindElement(By.Id("input-password-confirm"));
            var mr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(1) > input"));
            var ms = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"));
            var firstname = driver.FindElement(By.Id("input-first-name"));
            var lastname = driver.FindElement(By.Id("input-last-name"));
            var email = driver.FindElement(By.Id("input-email"));
            var dateofbirth = driver.FindElement(By.Id("input-dob"));
            var nationality = driver.FindElement(By.Id("input-nationality"));
            var terms = driver.FindElement(By.Id("terms"));
            var submit = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(13) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"));
            var confpasswordError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback"));
            var firstnameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback"));
            var lastnameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback"));
            var emailError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback"));


            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            confpassword.Clear();
            confpassword.SendKeys(confpass);

            mr.Click();

            firstname.Clear();
            firstname.SendKeys(fname);

            lastname.Clear();
            lastname.SendKeys(lname);

            email.Clear();
            email.SendKeys(mail);

            dateofbirth.Clear();
            dateofbirth.SendKeys(dob);

            nationality.SendKeys(nation);

            terms.Click();

            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passErr, passwordError.Text);
            Assert.AreEqual(confpassErr, confpasswordError.Text);
            Assert.AreEqual(fnameErr, firstnameError.Text);
            Assert.AreEqual(lnameErr, lastnameError.Text);
            Assert.AreEqual(mailErr, emailError.Text);

        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }    
     }
}
