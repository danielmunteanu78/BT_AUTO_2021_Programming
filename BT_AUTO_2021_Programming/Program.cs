﻿using System;

namespace BT_AUTO_2021_Programming
{
    class Program
    {

        static void Main(string[] args)
        {

            //Course01(args);
            // Course02(args);
            //Course03(args);
            Course04();

            static void Course01(string[] args)

            {
                const int MAX_SIZE = 100;
                const double PI = 3.141592;
                const int MAX_NUMBER = 5;

                Console.WriteLine("Hello World!");
                Console.WriteLine("Ana are mere");
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
                char ch = 'd';

                string myString = "Ana are mere si pere";
                Console.WriteLine(myString + " si struguri");
                DateTime dataCurenta = new DateTime(2021, 12, 8);
                Console.WriteLine(dataCurenta);

                Console.WriteLine(numberFloat * a);
                Console.WriteLine(5 / 6.0);
                Console.WriteLine(5 % 6);

                int x = 2;
                x += 5;
                //x++ 
                Console.WriteLine(++x);
                Console.WriteLine((x < a) ^ (x == a));

                int number = 9;
                Console.WriteLine("Number tested is " + number);
                if (number >= 0)
                {
                    Console.WriteLine("Number is positive !");
                }
                else
                {
                    Console.WriteLine("Number is negative !");
                }

                if (number % 2 == 0)
                {
                    Console.WriteLine("Even number");
                }
                else
                {
                    Console.WriteLine("Odd number");
                }

                if (number <= 40 && number >= 0)
                {
                    if (number <= 20)
                    {
                        Console.WriteLine("Student failed");
                    }
                    else
                    {
                        Console.WriteLine("Student passed ");
                    }
                }
                else
                {
                    Console.WriteLine("Grade is invalid");
                }

                // one line if/else
                String message = (number % 2 == 0) ? "Even" : "Odd";
                Console.WriteLine(message);

                if (number == 1)
                {
                    Console.WriteLine("Monday");
                }
                if (number == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                if (number == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                if (number == 4)
                {
                    Console.WriteLine("Thursday");
                }
                if (number == 5)
                {
                    Console.WriteLine("Friday");
                }
                if (number == 6)
                {
                    Console.WriteLine("Saturday");
                }
                if (number == 7)
                {
                    Console.WriteLine("Sunday");
                }
                if (number < 1 || number > 7)
                {
                    Console.WriteLine("Not valid");
                }

                switch (number)
                {
                    case 1:
                        {
                            Console.WriteLine("Monday");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Tuesday");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Wednesday");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Thursday");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Friday");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Saturday");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Sunday");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not a valid day!");
                            break;
                        }
                }

                int counter = 0;
                while (counter <= MAX_NUMBER)
                {
                    Console.WriteLine("Current number is: " + counter);
                    counter++;
                }

                counter = 0;
                do
                {
                    Console.WriteLine("Current number is: " + counter);
                    counter++;
                }
                while (counter <= MAX_NUMBER);

                for (counter = 0; counter <= MAX_NUMBER; counter++)
                {
                    Console.WriteLine("Current number is: {0} ", counter);
                }

                foreach (string argument in args)
                {
                    Console.WriteLine("The argument is: {0}", argument);
                }

                /*for (counter = 0; counter < args.Length; counter++)
                {
                    Console.WriteLine("The argument is: {0}", args[counter]);
                }*/

                foreach (string yr in args)
                {
                    int febDays = 28;
                    int year = int.Parse(yr);
                    if (year < 1900 || year > 2016)
                    {
                        Console.WriteLine("Year is outside valide bounds (1900-2016)");
                    }
                    else
                    {
                        if ((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 != 0))
                        {
                            febDays = 29;
                        }
                        Console.WriteLine("February has {0} days for year {1}", febDays, year);
                    }
                }
            }
            static void Course02(string[] args)
            {
                Circle c1 = new Circle();
                Circle c2; // c2 will be null !!!
                c1.SetRadius(10);
                double area = c1.GetArea();
                //Console.WriteLine(area);
                c1.PrintCircle();
                Circle c3 = new Circle();
                c3.SetRadius(5);
                //Console.WriteLine(c3.GetArea());
                c3.PrintCircle();
                foreach (string p in args)
                {
                    Circle c = new Circle();
                    c.SetRadius(Double.Parse(p));
                    Square s = new Square();
                    Rectangle r = new Rectangle();
                    r.SetSize(double.Parse(p), double.Parse(p));
                    s.SetSide(Double.Parse(p));
                    c.PrintCircle();
                    s.PrintSquare();
                    r.PrintRectangle();
                }

                Person p1 = new Person();
                p1.SetName("Alex");
                p1.SetSex('m');
                p1.Eat();
                p1.Run();
                p1.Eat();
                p1.PrintPerson();

                Rectangle r1 = new Rectangle();
                r1.SetSize(2, 3);
                r1.PrintRectangle();
            }
            static void Course03(string[] args)

            {
                ComputeConversion(args);
                CurrencyCalculator(156, "USD", 4.3734);
                Shape s = GetShape(12, 34, 12.4, 'a', "17d");
                //Console.WriteLine(ConcatenateStrings(args));
                Random rnd = new Random();
                GuessNumber(rnd.Next(0, 1000));                                 
            }

            static void Course04()
            {
                DrawFullShape(5, 3);
                Console.WriteLine();
                DrawShapeOutline(22, 22);
                Console.WriteLine();
                DrawShapeCorners(10, 10);

                Circle c1 = new Circle();
                Circle c2 = new Circle(10);
                //Circle c3 = new Circle("abc");
                c1.PrintCircle(); //instantiate c1 with default (no params) constructor
                c2.PrintCircle(); // instantiate c2 with constructor having 1 double param

                Person p1 = new Person();
                Person p2 = new Person("Alex",'m', new string[] { "Romanian" }, false, new DateTime());
                p1.PrintPerson();
                p2.PrintPerson();

                Rectangle r1 = new Rectangle(10, 7);
                r1.PrintRectangle();

                Square s1 = new Square(6);
                s1.PrintSquare();

                StructExample se = new StructExample();
                StructExample.MyStruct myStruct = new StructExample.MyStruct();
                myStruct.Assign(10, "abc");
                Console.WriteLine(myStruct.ComputeSum());

            }

            static void DrawShapeOutline(int width, int height)
            {
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++) // this will print a single line with * counting width
                    {
                        if (j==0 || j== height-1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            if(i==0 || i == width - 1)
                                {
                                Console.Write("*");
                                }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }

            static void DrawShapeCorners(int width, int height)
            {
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++) // this will print a single line with * counting width
                    {
                        if ((j == 0 && i == 0) || (j == 0 && i == width - 1) || (j == height - 1 && i == 0) || (j == height - 1 && i == width - 1))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }                        
                    }
                    Console.WriteLine();
                }
            }

            static void DrawFullShape(int width, int height)
            {
                for (int j = 0; j< height; j++)
                {
                    for(int i = 0; i < width; i++) // this will print a single line with * counting width
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            
            static bool IsOddNumber(int number)
            {
                return number % 2 != 0;
            }

            static int TestValue(int TestValue, int target)
            {

                if (TestValue < target)
                {
                    Console.WriteLine("Number to be guesed is higher");
                    return -1;
                }
                if (TestValue > target)
                {
                    Console.WriteLine("Number to be guesed is lower");
                    return 1;
                }
                Console.WriteLine("Bazinga !!! This is the number");
                return 0;
            }

            static void GuessNumber(int n)
            {
                int currentNumber = 0;
                do
                {
                    currentNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Number chosen is {0}", currentNumber);
                }
                while (TestValue(currentNumber, n) != 0);
            }

            static Shape GetShape(int x, int y, double a, char t, String s)
             {
             Console.WriteLine(x);
             return new Shape();
             }

             static string ConcatenateStrings(string[] args)
             {
                 string returnString = "";

                 foreach (string s in args)
                 {
                  returnString += s; // returnString = returnString + s;
                 }
                 return returnString;
             }               
                    

              static void ComputeConversion(string[] args)
              {
                  if (args.Length != 3)
                   {
                       Console.WriteLine("The app receives only 3 parameters : amount, currency and exchange rate");
                   }
                   else
                    {
                    Console.WriteLine("{0} {1} {2}", args[0], args[1], args[2]);
                    CurrencyCalculator(Double.Parse(args[0]), args[1], Double.Parse(args[2]));
                    }
               }

               static void CurrencyCalculator(double amount, string currency, double convertionRate)
               {
                   Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON ", amount, currency, amount * convertionRate);
               }              
            
        }
    }
}
