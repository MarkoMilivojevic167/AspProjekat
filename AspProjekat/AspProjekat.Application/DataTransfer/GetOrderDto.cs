using AspProjekat.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Application.DataTransfer
{
    public class GetOrderDto
    {
        public string Adress { get; set; }
        public OrderStatus orderStatus { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<string> ProductName { get; set; }
        public IEnumerable<int> Quantity { get; set; }
        public IEnumerable<decimal> Price { get; set; }
    }
}
