using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Implementation.Validators
{
    public class UploudImageValidator : AbstractValidator<ImageDto>
    {
        public UploudImageValidator(AspProjekatContext context)
        {
            RuleFor(y => y.Path)
               .NotEmpty()
               .WithMessage("Path is required!");
            RuleFor(y => y.ProductId)
               .NotEmpty()
               .WithMessage("Id is required!");
        }
    }
}
