using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Balance
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string msg) : base(msg) { }
    }
}
