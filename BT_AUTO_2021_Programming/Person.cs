﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Person
    {
        string name;
        char sex;
        string[] nationality;
        bool isHungry;
        DateTime dob;

        public void Eat()
        {
            Console.WriteLine("The person is eating ... ");
            isHungry = false;
        }

        public void Run ()
        {
            Console.WriteLine("The person is ruuning for his health!");
            isHungry = true;
        }

        public void SetName(string personName)
        {
            name = personName;
        }

        public void SetSex(char sex)
        {
            this.sex = sex;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Name of the person is: {0}", name);
            Console.WriteLine("-> Current state of hungry is {0}", isHungry);
            Console.WriteLine("-> Person sex is: {0}", sex);
        }
    }
}
