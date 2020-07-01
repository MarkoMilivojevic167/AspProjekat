using AspProjekat.Application.Commands;
using AspProjekat.Application.DataTransfer;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using AspProjekat.Implementation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfCreateCategoryCommand : ICreateCategoryCommand
    {
        private readonly AspProjekatContext _context;
        private readonly CreateCategoryValidator _validator;

        public EfCreateCategoryCommand(AspProjekatContext context , CreateCategoryValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 4;

        public string Name => "Create New Category using EF";

        public void Execute(CategoryDto request)
        {

            _validator.ValidateAndThrow(request);
            var category = new Category
            {
                Name = request.Name,
                CreatedAt = DateTime.Now,
                IsActive = true
            };

            _context.Categories.Add(category);

            _context.SaveChanges();
        }
    }
}
