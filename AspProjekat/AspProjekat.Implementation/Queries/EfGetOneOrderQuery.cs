using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Exceptions;
using AspProjekat.Application.Queries;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Queries
{
    public class EfGetOneOrderQuery : IGetOneOrderQuery
    {
        private readonly AspProjekatContext context;

        public EfGetOneOrderQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 18;

        public string Name => "Get one order.";

        public GetOrderDto Execute(int search)
        {
            var query = context.Orders.Include(x => x.OrderInfo).Include(y => y.User).AsQueryable().IgnoreQueryFilters();
            query = query.Where(x => x.Id == search);
            if (context.Orders.Any(x => x.Id == search))
            {
                var order = query.Select(x => new GetOrderDto
                {

                    Adress = x.Address,
                    orderStatus = x.OrderStatus,
                    FirstName = x.User.FirstName,
                    LastName = x.User.LastName,
                    Date = x.Date,
                    ProductName = x.OrderInfo.Select(x => x.Name),
                    Quantity = x.OrderInfo.Select(x => x.Quantity),
                    Price = x.OrderInfo.Select(x => x.Price)

                }).First();
                return order;
            }
            else
            {
                throw new EntityNotFoundException(search, typeof(Order));
            }
        }
    }
}
