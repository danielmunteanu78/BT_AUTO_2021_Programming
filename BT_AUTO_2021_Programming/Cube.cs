using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Cube
    {
        double length;
        public Cube(double length)
        {
            this.length = length;
        }

        public double GetVolume(double cubeVol)
        {
            cubeVol = Math.Pow(length, 3);
            return cubeVol;
        }

        /*public void PrintCube()
        {
            Console.WriteLine("The volume of the cube with side {0} is: {1}", length, GetVolume());
        }*/

    }
}
