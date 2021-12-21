﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Teacher : Person
    {
        string courseSpecialisation;
        string university;
        double salary;

        public Teacher(string courseSpecialisation, string university, double salary)
        {
            this.courseSpecialisation = courseSpecialisation;
            this.university = university;
            this.salary = salary;
        }

        public Teacher(string courseSpecialisation, string university, double salary, string name, char sex)
        {
            this.courseSpecialisation = courseSpecialisation;
            this.university = university;
            this.salary = salary;
            this.SetSex(sex);
            this.SetName(name);
        }
        public Teacher()
        {

        }

        public void Teach()
        {
            Console.WriteLine("Theacher is teaching specialisation {0} ", courseSpecialisation);
        }

        public void PrintTeacher()
        {
            base.PrintPerson();
            Console.WriteLine("Teacher works at univeristy {0} on specialisation {1} and has salary {2} EUR ", university,courseSpecialisation, salary);
        }
    }
}
