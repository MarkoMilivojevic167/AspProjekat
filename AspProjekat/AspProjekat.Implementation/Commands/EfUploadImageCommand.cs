using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using AspProjekat.Implementation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using AspProjekat.Application.Commands;
using AspProjekat.Domain.Entity;
using AspProjekat.Application.Exceptions;

namespace AspProjekat.Implementation.Commands
{
    public class EfUploadImageCommand : IUploadImageCommand
    {
        private readonly AspProjekatContext _context;
        private readonly UploudImageValidator validator;
        public EfUploadImageCommand(AspProjekatContext context, UploudImageValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 23;

        public string Name => "Image upload using Ef-a";

        public void Execute(ImageDto request)
        {
            if (_context.Products.Any(x => x.Id == request.ProductId))
            {
                validator.ValidateAndThrow(request);
                var newPath = UploadImageFunction.UploadImage(request.Path);

                    var image = new Image
                    {
                        Path = newPath,
                        Alt=request.Alt,
                        ProductId = request.ProductId
                    };
                    _context.Images.Add(image);
                
                _context.SaveChanges();
            }
            else
            {
                throw new EntityNotFoundException(request.ProductId, typeof(Product));
            }
        }
    }
}
