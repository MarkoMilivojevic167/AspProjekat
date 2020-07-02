using AspProjekat.Application.Commands;
using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Email;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using AspProjekat.Implementation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfRegisterUserCommand : IRegisterUserCommand
    {
        public int Id => 22;

        public string Name => "User Registration";

        private readonly AspProjekatContext _context;
        private readonly RegisterUserValidator _validator;
        private readonly IEmailSender _sender;

        public EfRegisterUserCommand(AspProjekatContext context, RegisterUserValidator validator, IEmailSender sender)
        {
            _context = context;
            _validator = validator;
            _sender = sender;
        }

        public void Execute(RegisterUserDto request)
        {
            _validator.ValidateAndThrow(request);

            _context.Users.Add(new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Username = request.Username,
                Password = request.Password,
                Email = request.Email,
                RoleId=request.RoleId
            });

            _context.SaveChanges();

            _sender.Send(new SendEmailDto
            {
                Content = "<h1>Successfull registration!</h1>",
                SendTo = request.Email,
                Subject = "Registration"
            });
        }
    }
}
