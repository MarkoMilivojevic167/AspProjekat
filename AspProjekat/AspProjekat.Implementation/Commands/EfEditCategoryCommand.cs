using AspProjekat.Application.Commands;
using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Exceptions;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using AspProjekat.Implementation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfEditCategoryCommand : IEditCategoryCommand
    {
        private readonly AspProjekatContext _context;
        private readonly CreateCategoryValidator _validator;

        public EfEditCategoryCommand(AspProjekatContext context, CreateCategoryValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 10;

        public string Name => "Edit Category using EF";

        public void Execute(CategoryDto request)
        {



        }
    }
}
