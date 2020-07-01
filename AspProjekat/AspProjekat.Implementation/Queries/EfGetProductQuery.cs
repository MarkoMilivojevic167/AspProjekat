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
    public class EfGetProductQuery : IGetProductQuery
    {
        private readonly AspProjekatContext context;

        public EfGetProductQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 6;

        public string Name => "Category search.";

        public PageResponse<ProductDto> Execute(ProductSearch search)
        {
            var query = context.Categories.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);


            var reponse = new PageResponse<ProductDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new ProductDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList()
            };

            return reponse;
        }
    }
}
