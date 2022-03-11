using System;
using System.Collections.Generic;
using System.Text;

namespace P129CustomException.Exceptions
{
    class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(string message) : base(message)
        {
        }

        public StudentNotFoundException(string message, StudentNotFoundException innerException): base(message, innerException)
        {
        }
    }
}
