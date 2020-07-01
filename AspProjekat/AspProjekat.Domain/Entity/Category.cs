using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspProjekat.Domain.Entity
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
