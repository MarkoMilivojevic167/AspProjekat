using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Validators
{
    public class RegisterUserValidator : AbstractValidator<RegisterUserDto>
    {

        public RegisterUserValidator(AspProjekatContext context)
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(x => x.Username)
                .NotEmpty()
                .MinimumLength(4)
                .Must(x => !context.Users.Any(user => user.Username == x))
                .WithMessage("Username is already taken.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.RoleId)
                .NotEmpty()
                .Must(id => context.Roles.Any(x => x.Id == id))
                .WithMessage("Role doesnt exist.");


        }
    }
}
