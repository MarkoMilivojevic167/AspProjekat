using AspProjekat.Application.Commands;
using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Exceptions;
using AspProjekat.Domain.Entity;
using AspProjekat.EfDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Commands
{
    public class EfChangeStatusOrderCommand : IChangeStatusOrderCommand
    {
        private readonly AspProjekatContext _context;

        public EfChangeStatusOrderCommand(AspProjekatContext context)
        {
            _context = context;
        }

        public int Id => 16;

        public string Name => "Change order status using Ef";

        public void Execute(ChnageOrderStatusDto request)
        {
            if (_context.Orders.Any(x => x.Id == request.OrderId))
            {
                var order = _context.Orders
               .Include(p => p.OrderInfo)
               .ThenInclude(pd => pd.Product)
               .FirstOrDefault(x => x.Id == request.OrderId);
                if (order == null)
                {
                }
                if (order.OrderStatus == OrderStatus.Recieved)
                {
                }
                if (order.OrderStatus == OrderStatus.Recieved || order.OrderStatus == OrderStatus.Delivered)
                {
                    if (request.Status == OrderStatus.Canceled || request.Status == OrderStatus.Delivered)
                    {
                        order.OrderStatus = request.Status;
                        if (request.Status == OrderStatus.Canceled)
                        {
                            foreach (var n in order.OrderInfo)
                            {
                                n.Product.Quantity += n.Quantity;
                            }
                        }
                        _context.SaveChanges();

                    }
                }
            }
            else
            {
                throw new EntityNotFoundException(request.OrderId, typeof(Order));
            }

        }
    }
}
