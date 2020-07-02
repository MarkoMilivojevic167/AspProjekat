using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Exceptions;
using AspProjekat.Application.Queries;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Queries
{
    public class EfGetOneUserQuery : IGetOneUserQuery
    {
        private readonly AspProjekatContext context;

        public EfGetOneUserQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 21;

        public string Name => "Get one user.";

        public GetUserDto Execute(int search)
        {
            var query = context.Users.Include(x => x.Role).AsQueryable();
            query = query.Where(x => x.Id == search);
            if (context.Users.Any(x => x.Id == search))
            {
                var user = query.Select(x => new GetUserDto
                {
                    FirstName = x.FirstName,
                    LastName = x.FirstName,
                    Username = x.FirstName,
                    Email = x.Email,
                    RoleId = x.RoleId
                }).First();
                return user;
            }
            else
            {

                throw new EntityNotFoundException(search, typeof(User));
            }


        }
    }
}
