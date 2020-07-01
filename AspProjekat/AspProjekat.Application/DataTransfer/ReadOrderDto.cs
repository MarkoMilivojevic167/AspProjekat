using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProjekat.Application.DataTransfer
{
    public class ReadOrderDto
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
        public string UserInfo { get; set; }
        public IEnumerable<ReadOrderInfoDto> OrderInfo { get; set; } = new List<ReadOrderInfoDto>();
        public decimal TotalPrice => OrderInfo.Sum(x => x.Price * x.Quantity);
    }

    public class ReadOrderInfoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
