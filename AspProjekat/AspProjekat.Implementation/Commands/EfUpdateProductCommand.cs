using AspProjekat.Application.Commands;
using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Exceptions;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using AspProjekat.Implementation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfUpdateProductCommand : IUpdateProductCommand
    {
        private readonly AspProjekatContext _context;
        private readonly UpdateProductValidator _validator;
        private readonly ProductNameValidator _validatorName;
        

        public EfUpdateProductCommand(AspProjekatContext context, UpdateProductValidator validator, ProductNameValidator validatorName)
        {
            _context = context;
            _validator = validator;
            _validatorName = validatorName;
        }

        public int Id => 11;

        public string Name => "Update product using EF";

        public void Execute(UpdateProductDto request)
        {
            if (_context.Products.Any(x => x.Id == request.Id))
            {
                var oneProduct = _context.Products.Find(request.Id);
                if (request.Name == oneProduct.Name)
                {
                    _validator.ValidateAndThrow(request);
                    oneProduct.Name = request.Name;
                    oneProduct.Description = request.Description;
                    oneProduct.Price = request.Price;
                    //oneProduct.Slika = UploadJedneSlike.UploadJednaSlika(request.Slika);
                    oneProduct.Quantity += request.Quantity;
                    oneProduct.ModifiedAt = DateTime.Now;

                    _context.SaveChanges();

                }
                else
                {
                    _validatorName.ValidateAndThrow(request);
                    oneProduct.Name = request.Name;
                    oneProduct.Description = request.Description;
                    oneProduct.Price = request.Price;
                    //oneProduct.Slika = UploadJedneSlike.UploadJednaSlika(request.Slika);
                    oneProduct.Quantity += request.Quantity;
                    oneProduct.ModifiedAt = DateTime.Now;

                    _context.SaveChanges();
                }
            }
            else
            {
                throw new EntityNotFoundException(request.Id, typeof(Product));
            }
        }
    }
}
