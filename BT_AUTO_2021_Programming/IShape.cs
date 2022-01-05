using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    interface IShape
    {
        void Draw();
        void Color();

        // this is valid for C# version >= 8.0
        void State()
        {
            Console.WriteLine("State of the Shape");
        }
    }
}
