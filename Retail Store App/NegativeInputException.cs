using System;
using System.Collections.Generic;
using System.Text;

namespace Retail_Store_App
{
    public class NegativeInputException : Exception
    {
        public NegativeInputException(string msg) : base(msg) { }
    }
}
