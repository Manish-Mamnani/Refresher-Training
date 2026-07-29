using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse_Volume
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string msg) : base(msg) { }
    }
}
