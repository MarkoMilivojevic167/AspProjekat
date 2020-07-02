using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Queries;
using AspProjekat.Application.Searches;
using AspProjekat.EfDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Queries
{
    public class EfGetOrderQuery : IGetOrdersQuery
    {
        private readonly AspProjekatContext context;

        public EfGetOrderQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 17;

        public string Name => "Order search.";

        public PageResponse<GetOrderDto> Execute(OrderSearch search)
        {
            var query = context.Orders.Include(x => x.OrderInfo).Include(y => y.User).AsQueryable();
            DateTime dateTime = new DateTime();
            string date = search.OrderDate.Date.ToString("yyyy-MM-dd");
            if (search.OrderDate != dateTime)
            {
                query = query.Where(x => x.Date.Date.ToString() == date);
            }

            var skipCount = search.PerPage * (search.Page - 1);
            var response = new PageResponse<GetOrderDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new GetOrderDto
                {
                    Adress = x.Address,
                    orderStatus = x.OrderStatus,
                    FirstName = x.User.FirstName,
                    LastName = x.User.LastName,
                    Date=x.Date,
                    ProductName = x.OrderInfo.Select(x => x.Name),
                    Quantity = x.OrderInfo.Select(x => x.Quantity),
                    Price = x.OrderInfo.Select(x => x.Price)

                }).ToList()

            };
            return response;
        }
    }
}
