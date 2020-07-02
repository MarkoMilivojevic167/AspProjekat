using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Application.Exceptions
{
    public class ConflictException : Exception
    {
        public ConflictException(string name, Type type) : base($"{name} exist in table: {type.Name}")
        {

        }
    }
}
