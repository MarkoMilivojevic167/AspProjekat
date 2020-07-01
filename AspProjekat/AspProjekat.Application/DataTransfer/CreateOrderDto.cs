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
        public IEnumerable<CreateOrderLineDto> Items { get; set; } = new List<CreateOrderLineDto>();
    }

    public class CreateOrderLineDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
    
}
