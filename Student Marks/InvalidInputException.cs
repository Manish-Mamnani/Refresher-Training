using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Marks
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string msg) : base(msg) { }
    }
}
