using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Queries;
using AspProjekat.Application.Searches;
using AspProjekat.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Queries
{
    public class EfGetUserQuery : IGetUserQuery
    {
        private readonly AspProjekatContext context;

        public EfGetUserQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 27;

        public string Name => "User search.";

        public PageResponse<UserDto> Execute(UserSearch search)
        {
            var query = context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.FirstName.ToLower().Contains(search.Name.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);


            var reponse = new PageResponse<UserDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new UserDto
                {
                    LastName=x.LastName,
                    FirstName = x.FirstName,
                    RoleId=x.RoleId,
                    Email=x.Email,
                    Username=x.Username
                }).ToList()
            };

            return reponse;
        }
    }
}
