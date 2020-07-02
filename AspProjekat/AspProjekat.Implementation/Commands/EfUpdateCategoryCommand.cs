using AspProjekat.Application.Commands;
using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Exceptions;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfUpdateCategoryCommand : IUpdateCategoryCommand
    {
        private readonly AspProjekatContext _context;

        public EfUpdateCategoryCommand(AspProjekatContext context)
        {
            _context = context;
        }

        public int Id => 13;

        public string Name => "Update Category using Ef";

        public void Execute(CategoryDto request)
        {
            var jednaKategorija = _context.Categories.Find(request.Id);
            if (_context.Categories.Any(x => x.Id == request.Id))
            {
                if (request.Name == jednaKategorija.Name)
                {
                    var oneCategory = _context.Categories.Find(request.Id);
                    oneCategory.Name = request.Name;
                    oneCategory.ModifiedAt = DateTime.Now;
                    _context.SaveChanges();
                }
                else
                {
                    if (_context.Categories.Any(x => x.Name == request.Name))
                    {
                        throw new ConflictException(request.Name, typeof(Category));
                    }
                    else
                    {
                        if (request.Name == null)
                        {
                            throw new EntityNotFoundException(request.Id, typeof(Category));
                        }
                        else
                        {
                            var oneCategory = _context.Categories.Find(request.Id);
                            oneCategory.Name = request.Name;
                            oneCategory.ModifiedAt = DateTime.Now;
                            _context.SaveChanges();
                        }

                    }
                }
            }
            else
            {
                throw new EntityNotFoundException(request.Id, typeof(Category));
            }
        }
    }
}
