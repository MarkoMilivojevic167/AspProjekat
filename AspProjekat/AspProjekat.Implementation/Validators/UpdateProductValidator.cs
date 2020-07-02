using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Implementation.Validators
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductDto>
    {
        public UpdateProductValidator(AspProjekatContext context)
        {
            RuleFor(y => y.Name)
                  .NotEmpty()
                 .WithMessage("Name is required!");
            RuleFor(y => y.Description)
                .NotEmpty()
                .WithMessage("Description is required!");
            //RuleFor(y => y.Slika)
            //   .NotEmpty()
            //   .WithMessage("Polje slika ne sme da bude prazno!");
            RuleFor(y => y.Quantity)
               .NotEmpty()
               .WithMessage("Quantity is required!");
            RuleFor(y => y.Price)
               .NotEmpty()
               .WithMessage("Price is required!");
        }
    }
}
