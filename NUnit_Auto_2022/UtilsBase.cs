namespace NUnit_Auto_2022
{
    public class UtilsBase
    {

        public static void PrintCookies(ICookieJar)
        {
            foreach (Cookie c in AllCookies)
            {
                Console.WriteLine("Cookie name {0} cookie value {1}", c.Name, c.Value);
            }
        }
    }
}