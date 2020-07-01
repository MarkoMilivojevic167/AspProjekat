using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Validators
{
    public class CreateProductValidator : AbstractValidator<ProductDto>
    {
        public CreateProductValidator(AspProjekatContext context)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Must(name => !context.Categories.Any(g => g.Name == name))
                .WithMessage("Product name must be unique");

  
            RuleFor(x => x.Price).NotEmpty();
            RuleFor(x => x.Description)
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(x => x.Quantity).NotEmpty();

            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .Must(id => context.Categories.Any(x => x.Id == id))
                .WithMessage("Category doesnt exist.");
        }
    }
}
