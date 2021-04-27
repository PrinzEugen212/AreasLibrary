using System;

namespace AreasLibrary
{
    public class IncorrectTriangleException : Exception
    {
        public IncorrectTriangleException(string message) : base(message) { }
        public IncorrectTriangleException() : base() { }
    }
}
