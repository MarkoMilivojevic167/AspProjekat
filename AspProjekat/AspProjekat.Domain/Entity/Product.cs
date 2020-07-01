using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Domain.Entity
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<OrderInfo> OrderProducts { get; set; }

    }
}
