using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Domain.Entity
{
    public class Image : Entity
    {


        public string Path { get; set; }

        public string Alt { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
