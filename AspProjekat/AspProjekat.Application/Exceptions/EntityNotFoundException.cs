using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Application.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(int id, Type type)
            : base($"Entitet sa imenom: {type.Name} i id: {id} nije pronadjen.")
        {

        }
    }
}
