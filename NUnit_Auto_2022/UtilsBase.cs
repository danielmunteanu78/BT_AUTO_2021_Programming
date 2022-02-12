using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace NUnit_Auto_2022
{
    public class UtilsBase
    {
        public static IEnumerable<Cookie> AllCookies { get; private set; }

        public static void PrintCookies(ICookieJar cookie)
        {
            foreach (Cookie c in AllCookies)
            {
                Console.WriteLine("Cookie name {0} cookie value {1}", c.Name, c.Value);
            }
        }
    }
}