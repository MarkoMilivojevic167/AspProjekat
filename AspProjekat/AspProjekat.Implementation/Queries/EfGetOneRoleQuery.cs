using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Exceptions;
using AspProjekat.Application.Queries;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Queries
{
    public class EfGetOneRoleQuery : IGetOneRoleQuery
    {
        private readonly AspProjekatContext context;

        public EfGetOneRoleQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 22;

        public string Name => "Get one role.";

        public RoleDto Execute(int search)
        {
            var query = context.Roles.AsQueryable();
            query = query.Where(x => x.Id == search);
            if (context.Categories.Any(x => x.Id == search))
            {
                var role = query.Select(x => new RoleDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).First();
                return role;
            }
            else
            {
                throw new EntityNotFoundException(search, typeof(Role));
            }
        }
    }
}
