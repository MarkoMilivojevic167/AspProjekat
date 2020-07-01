using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Validators
{
    public class CreateCategoryValidator : AbstractValidator<CategoryDto>
    {

        public CreateCategoryValidator(AspProjekatContext context)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Must(name => !context.Categories.Any(g => g.Name == name))
                .WithMessage("Category name must be unique");
        }
    }
}
