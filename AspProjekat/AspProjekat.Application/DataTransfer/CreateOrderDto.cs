using AspProjekat.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProjekat.Application.DataTransfer
{
    public class CreateOrderDto
    {
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public IEnumerable<CreateOrderInfoDto> Items { get; set; } = new List<CreateOrderInfoDto>();
    }

    public class CreateOrderInfoDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
    public class ChnageOrderStatusDto
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
    }

}
