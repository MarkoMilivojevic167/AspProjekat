using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Application.DataTransfer
{
    public class GetProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
