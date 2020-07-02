using AspProjekat.Application;
using AspProjekat.Application.Commands;
using AspProjekat.Application.DataTransfer;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using AspProjekat.Implementation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfCrateOrderCommand : ICreateOrderCommand
    {
        private readonly AspProjekatContext _context;
        private readonly CreateOrderValidator _validator;
        private readonly IApplicationActor actor;

        public EfCrateOrderCommand(AspProjekatContext context, CreateOrderValidator validator, IApplicationActor actor)
        {
            _context = context;
            _validator = validator;
            this.actor = actor;
        }

        public int Id => 14;

        public string Name => "Create Order using EF";

        public void Execute(CreateOrderDto request)
        {

            _validator.ValidateAndThrow(request);
            int IdUser = actor.Id;
            var order = new Order
            {
                UserId = IdUser,
                Address = request.Address,
                Date = request.OrderDate
            };
            foreach (var item in request.Items)
            {
                var product = _context.Products.Find(item.ProductId);
                product.Quantity -= item.Quantity;
                order.OrderInfo.Add(new OrderInfo
                {
                    Name = product.Name,
                    Quantity = item.Quantity,
                    Price = product.Price,
                    ProductId = item.ProductId,

                }); ;
            }
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
