using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Validators
{
    public class ProductNameValidator : AbstractValidator<UpdateProductDto>
    {
        public ProductNameValidator(AspProjekatContext context)
        {
            RuleFor(y => y.Name)
              .Must(name => !context.Products.Any(k => k.Name == name))
              .WithMessage("Name is not uniqe!");
        }
    }
}
