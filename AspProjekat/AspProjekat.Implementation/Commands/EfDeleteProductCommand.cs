using AspProjekat.Application.Commands;
using AspProjekat.Application.Exceptions;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfDeleteProductCommand : IDeleteProductCommand
    {
        private readonly AspProjekatContext _context;

        public EfDeleteProductCommand(AspProjekatContext context)
        {
            this._context = context;
        }

        public int Id => 8;

        public string Name => "Deleting product";

        public void Execute(int request)
        {
            var product = _context.Products.Find(request);

            if (product == null)
            {
                throw new EntityNotFoundException(request, typeof(Product));
            }

            _context.Products.Remove(product);

            _context.SaveChanges();
        }
    }
}
