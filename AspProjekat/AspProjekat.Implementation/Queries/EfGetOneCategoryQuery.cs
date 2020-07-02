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
    public class EfGetOneCategoryQuery : IGetOneCategoryQuery
    {
        private readonly AspProjekatContext context;

        public EfGetOneCategoryQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 19;

        public string Name => "Get one category.";

        public CategoryDto Execute(int search)
        {
            var query = context.Categories.AsQueryable();
            query = query.Where(x => x.Id == search);
            if (context.Categories.Any(x => x.Id == search))
            {
                var category = query.Select(x => new CategoryDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).First();
                return category;
            }
            else
            {
                throw new EntityNotFoundException(search, typeof(Category));
            }
        }
    }
}
