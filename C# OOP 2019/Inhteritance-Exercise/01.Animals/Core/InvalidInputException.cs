using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Animals.Core
{
    public class InvalidInputException : Exception
    {
        public override string Message => "Invalid input!";
    }
}
