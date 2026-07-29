using System;
using System.Collections.Generic;
using System.Text;

namespace Body_Mass_Index
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string msg) : base(msg) { }
    }
}
