﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Rectangle: Shape
    {
        double lenght;
        double width;

        public Rectangle(double lenght,double width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public Rectangle()
        {

        }

        public void SetSize(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public virtual double GetArea()
        {
            return lenght * width;
        }

        public void PrintRectangle()
        {
            Console.WriteLine("The rectangle with lenght {0} and width {1} has area {2}", lenght, width, GetArea());
        }

        public override string ToString()
        {
            return "This is a rectangle with " + width + " width and " + lenght + " lenght";
        }
    }
}
