using System;
using System.Collections.Generic;
using System.Text;

namespace AreasLibrary
{
    public class IncorrectCircleException : Exception
    {
        public IncorrectCircleException(string message) : base(message) { }
        public IncorrectCircleException() : base() { }
    }
}
