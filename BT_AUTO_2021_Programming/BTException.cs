using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class BTException : Exception
    {
        string myCustomMessage;
        public BTException(string message)
        {
            this.myCustomMessage = "BT Exception: " + message;
        }
        
        public BTException(): base ("BT Exception: ")
        {

        }

        public override string ToString()
        {
            return myCustomMessage + base.ToString();
        }
    }
}
