using System;

namespace BT_AUTO_2021_Programming
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MAX_SIZE = 100;
            const double PI = 3.141592;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are pere");
            Console.WriteLine(100 + 21);
            Console.WriteLine("100 + 21");
            int numberOfStudents = 5;
            int count;
            int a, b;
            a = numberOfStudents + 1;
            a = a + numberOfStudents;
                       
            short s = 5;
            long ul = 134;
            float numberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;
            long l = numberOfStudents;

            Console.WriteLine(typeof(int).IsPrimitive);

            bool myBoolean = false;
            char ch ='d';

            string myString = "Ana are mere si pere";
            Console.WriteLine(myString + " si struguri");
            DateTime dataCurenta = new DateTime(2021, 12, 8);
            Console.WriteLine(dataCurenta);

            Console.WriteLine(numberFloat * a);
            Console.WriteLine(5/6.0);
            Console.WriteLine(5 % 6);

            int x = 2;
            x += 5;
            //x++ 
            Console.WriteLine(++x);
            Console.WriteLine((x < a)^(x==a));
        }
    }
}
