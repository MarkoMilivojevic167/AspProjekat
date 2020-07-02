using AspProjekat.Application.DataTransfer;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Validators
{
    public class CreateOrderInfoValidator : AbstractValidator<CreateOrderInfoDto>
    {
        private readonly AspProjekatContext context;
        public CreateOrderInfoValidator(AspProjekatContext context)
        {
            this.context = context;


            RuleFor(x => x.ProductId)
                .Must(ProductExists)
                .WithMessage("Product with an id of {PropertyValue} doesn't exist.")
                .DependentRules(() =>
                {
                    RuleFor(x => x.Quantity)
                    .GreaterThan(0)
                    .WithMessage("Quantity must be greater than 0")
                    .Must(QuantityDoesentExeedProductQuantity)
                    .WithMessage("Defined quantity ({PropertyValue}) is unavailable.");
                });
        }

        private bool ProductExists(int productId)
        {
            return context.Products.Any(x => x.Id == productId);
        }

        private bool QuantityDoesentExeedProductQuantity(CreateOrderInfoDto dto, int quantity)
        {
            return context.Products.Find(dto.ProductId).Quantity >= quantity;
        }
    }
}

