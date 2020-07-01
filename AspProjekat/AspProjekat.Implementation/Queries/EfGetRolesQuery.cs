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
    public class EfGetRolesQuery : IGetRolesQuery
    {
        private readonly AspProjekatContext context;

        public EfGetRolesQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 5;

        public string Name => "Role search.";

        public PageResponse<RoleDto> Execute(RoleSearch search)
        {
            var query = context.Roles.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);


            var reponse = new PageResponse<RoleDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new RoleDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList()
            };

            return reponse;
        }
    }
}
