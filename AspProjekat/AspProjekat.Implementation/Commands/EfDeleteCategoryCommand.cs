using AspProjekat.Application.Commands;
using AspProjekat.Application.Exceptions;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfDeleteCategoryCommand : IDeleteCategoryCommand
    {
        private readonly AspProjekatContext _context;

        public EfDeleteCategoryCommand(AspProjekatContext context)
        {
            this._context = context;
        }

        public int Id => 5;

        public string Name => "Deleting category";

        public void Execute(int request)
        {
            var category = _context.Categories.Find(request);

            if (category == null)
            {
                throw new EntityNotFoundException(request, typeof(Category));
            }

            _context.Categories.Remove(category);

            _context.SaveChanges();
        }
    }
}
