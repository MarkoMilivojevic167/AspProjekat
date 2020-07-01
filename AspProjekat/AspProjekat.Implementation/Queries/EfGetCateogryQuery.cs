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
    public class EfGetCateogryQuery : IGetCategoriesQuery
    {
        private readonly AspProjekatContext context;

        public EfGetCateogryQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 6;

        public string Name => "Category search.";

        public PageResponse<CategoryDto> Execute(CategorySearch search)
        {
            var query = context.Categories.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);


            var reponse = new PageResponse<CategoryDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new CategoryDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList()
            };

            return reponse;
        }
    }
}
