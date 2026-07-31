using System;

namespace Shipping_Calculator
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message)
        {
        }
    }
}