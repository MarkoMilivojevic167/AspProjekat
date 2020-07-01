using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Validators
{
    public class CreateRoleValidator : AbstractValidator<RoleDto>
    {
        public CreateRoleValidator(AspProjekatContext context)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Must(name => !context.Roles.Any(g => g.Name == name))
                .WithMessage("Role name must be unique");
        }
    }
}
