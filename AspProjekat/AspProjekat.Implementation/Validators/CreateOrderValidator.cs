using AspProjekat.Application.DataTransfer;
using AspProjekat.EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace AspProjekat.Implementation.Validators
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderDto>
    {
        private readonly AspProjekatContext _context;
        public CreateOrderValidator(AspProjekatContext context)
        {
            _context = context;
            RuleFor(x => x.OrderDate).
                GreaterThan(DateTime.Today)
                .WithMessage("Order date must be in future.")
                .LessThan(DateTime.Now.AddDays(30))
                .WithMessage("Order date can't be more than 30 days from today.");

            RuleFor(x => x.Address)
                .NotEmpty()
                .WithMessage("Address is required.");

            RuleFor(x => x.Items)
                .NotEmpty()
                .WithMessage("There must be at least one order line.")
                .Must(i => i.Select(x => x.ProductId).Distinct().Count() == i.Count())
                .WithMessage("Duplicate products are not allowed.")
                .DependentRules(() =>
                {
                    RuleForEach(x => x.Items).SetValidator
                        (new CreateOrderInfoValidator(_context));
                });



        }
    }
}
