using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using AspProjekat.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using AspProjekat.Application.Commands;
using AspProjekat.Domain.Entity;
using AspProjekat.Implementation.Validators;
using FluentValidation;

namespace AspProjekat.Implementation.Commands
{
    public class EfCreateRoleCommand : ICreateRoleCommand
    {
        private readonly AspProjekatContext _context;
        private readonly CreateRoleValidator _validator;

        public EfCreateRoleCommand(AspProjekatContext context, CreateRoleValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 1;

        public string Name => "Create New Role using EF";

        public void Execute(RoleDto request)
        {
            _validator.ValidateAndThrow(request);

            var role = new Role
            {
                Name = request.Name,
                CreatedAt = DateTime.Now,
                IsActive = true
            };

            _context.Roles.Add(role);

            _context.SaveChanges();
        }
    }
}
