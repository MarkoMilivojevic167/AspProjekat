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
    public class EfCreateProductCommand : ICreateProductCommand
    {
        private readonly AspProjekatContext _context;
        private readonly CreateProductValidator _validator;

        public EfCreateProductCommand(AspProjekatContext context, CreateProductValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 7;

        public string Name => "Create New Product using EF";

        public void Execute(ProductDto request)
        {

            _validator.ValidateAndThrow(request);
            var product = new Product
            {
                Name = request.Name,
                Price= request.Price,
                Description = request.Description,
                Quantity = request.Quantity,
                CategoryId = request.CategoryId,
                CreatedAt = DateTime.Now,
                IsActive = true
            };

            _context.Products.Add(product);

            _context.SaveChanges();
        }
    }
}
