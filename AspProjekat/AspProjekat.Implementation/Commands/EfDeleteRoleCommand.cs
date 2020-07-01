using AspProjekat.Application.Commands;
using AspProjekat.Application.Exceptions;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfDeleteRoleCommand : IDeleteRoleCommand
    {
        private readonly AspProjekatContext _context;

        public EfDeleteRoleCommand(AspProjekatContext context)
        {
            this._context = context;
        }

        public int Id => 2;

        public string Name => "Deleting role";

        public void Execute(int request)
        {
            var role = _context.Roles.Find(request);

            if (role == null)
            {
                throw new EntityNotFoundException(request, typeof(Role));
            }

            _context.Roles.Remove(role);

            _context.SaveChanges();
        }
    }
}

