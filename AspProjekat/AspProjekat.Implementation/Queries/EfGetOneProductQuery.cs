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
    public class EfGetOneProductQuery : IGetOneProductQuery
    {
        private readonly AspProjekatContext context;

        public EfGetOneProductQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 20;

        public string Name => "Get one product.";

        public GetProductDto Execute(int search)
        {
            //var query = context.Products.Include(x => x.Images).AsQueryable();
            var query = context.Products.AsQueryable();
            query = query.Where(x => x.Id == search);
            if (context.Products.Any(x => x.Id == search))
            {
                var product = query.Select(x => new GetProductDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    CategoryId = x.CategoryId,
                    Quantity = x.Quantity
                }).First();
                return product;
            }
            else
            {
                throw new EntityNotFoundException(search, typeof(Product));
            }
        }
    }
}
